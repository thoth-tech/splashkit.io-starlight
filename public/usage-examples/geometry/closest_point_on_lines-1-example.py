from splashkit import *
import math

# Declare a variable with snake_case (demonstrating naming style)
snap_point_to_nearest_line = "This is snake case"

# Calculate Euclidean distance between two points
def calculate_distance(point_a, point_b):
    return math.hypot(point_b.x - point_a.x, point_b.y - point_a.y)

# Find the closest point on a line segment to a given point using vector projection
def find_closest_point_on_line(from_point, line):
    start_point, end_point = line

    # Vector from start point to mouse point (AP)
    vector_ap_x = from_point.x - start_point.x
    vector_ap_y = from_point.y - start_point.y

    # Vector from start to end of the line (AB)
    vector_ab_x = end_point.x - start_point.x
    vector_ab_y = end_point.y - start_point.y

    # Project AP onto AB using dot product and clamp t between 0 and 1
    ab_length_squared = vector_ab_x**2 + vector_ab_y**2
    dot_product = vector_ap_x * vector_ab_x + vector_ap_y * vector_ab_y
    t = max(0, min(1, dot_product / ab_length_squared))  # ensures point stays on the segment

    # Calculate the coordinates of the closest point on the line
    closest_x = start_point.x + vector_ab_x * t
    closest_y = start_point.y + vector_ab_y * t

    return point_at(closest_x, closest_y)

def main():
    # Open a window for drawing
    open_window("Snap Point to Nearest Line", 600, 600)

    # Define two line segments as tuples of start and end points
    line_one = (point_at(100, 100), point_at(500, 100))
    line_two = (point_at(100, 300), point_at(500, 500))
    all_lines = [line_one, line_two]

    # Load a font for rendering text
    font = load_font("default_font", "Arial.ttf")

    # Main event loop - runs until the user closes the window
    while not quit_requested():
        process_events()               # Handle mouse and window events
        clear_screen(color_white())   # Clear screen with white background

        current_point = mouse_position()          # Get the current mouse position
        min_distance = float('inf')               # Track the minimum distance found
        nearest_snap_point = None                 # Closest point on a line
        nearest_line_index = -1                   # Index of the line with closest point

        # Iterate through all lines to find the closest point to the mouse
        for index, line in enumerate(all_lines):
            candidate_point = find_closest_point_on_line(current_point, line)
            candidate_distance = calculate_distance(current_point, candidate_point)

            # Update nearest point and line index if this one is closer
            if candidate_distance < min_distance:
                min_distance = candidate_distance
                nearest_snap_point = candidate_point
                nearest_line_index = index

        # Draw all the lines in gray
        for line in all_lines:
            draw_line(color_gray(), line[0].x, line[0].y, line[1].x, line[1].y)

        # Draw the user's current point in black
        fill_circle(color_black(), current_point.x, current_point.y, 5)

        # Draw the closest point on the nearest line in green
        fill_circle(color_green(), nearest_snap_point.x, nearest_snap_point.y, 5)

        # Draw a red line connecting the mouse point to the nearest snap point
        draw_line(color_red(), current_point.x, current_point.y, nearest_snap_point.x, nearest_snap_point.y)

        # Display labels near the points and on screen
        draw_text("Black: From Point", color_black(), font, 12, current_point.x + 10, current_point.y)
        draw_text("Green: Closest Point", color_green(), font, 12, nearest_snap_point.x + 10, nearest_snap_point.y)
        draw_text(f"Closest line index: {nearest_line_index}", color_blue(), font, 14, 20, 20)

        # Update the screen at 60 frames per second
        refresh_screen_with_target_fps(60)

    # Close the window when exiting
    close_window("Snap Point to Nearest Line")

# Run the main function
main()
