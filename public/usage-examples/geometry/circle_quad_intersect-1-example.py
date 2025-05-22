from splashkit import *

def main():
    # Open a graphical window with a title and fixed size
    window = open_window("Circle Quad Intersect Example", 800, 600)

    # Define the four corners of the quad using descriptive snake_case names
    top_left = point_at(300, 200)
    top_right = point_at(500, 200)
    bottom_right = point_at(500, 400)
    bottom_left = point_at(300, 400)

    # Create the quad using raw x and y values (required in Python)
    fixed_quad = quad_from(
    top_left.x, top_left.y,
    top_right.x, top_right.y,
    bottom_right.x, bottom_right.y,
    bottom_left.x, bottom_left.y
)

    # Set the radius for the mouse-following circle
    radius = 30

    # Main program loop — runs until the window is closed
    while not window_close_requested(window):
        # Handle mouse and keyboard events
        process_events()

        # Clear the screen with a dark slate gray background
        clear_screen(color_dark_slate_gray())

        # Get current mouse position
        mouse_pos = mouse_position()

        # Create a circle at the mouse position
        center = point_at(mouse_pos.x, mouse_pos.y)
        mouse_circle = circle_at(center, radius)

        # Check if the circle intersects with the quad
        if circle_quad_intersect(mouse_circle, fixed_quad):
            quad_color = color_red()   # Red if intersecting
        else:
            quad_color = color_green() # Green if not intersecting

        # Fill the quad using two triangles
        fill_triangle(quad_color,
                      top_left.x, top_left.y,
                      top_right.x, top_right.y,
                      bottom_right.x, bottom_right.y)

        fill_triangle(quad_color,
                      top_left.x, top_left.y,
                      bottom_left.x, bottom_left.y,
                      bottom_right.x, bottom_right.y)

        # Draw the mouse-following circle in white
        draw_circle(color_white(), center.x, center.y, radius)

        # Refresh the screen at 60 frames per second
        refresh_screen_with_target_fps(60)

# Run the main function to start the program
main()
