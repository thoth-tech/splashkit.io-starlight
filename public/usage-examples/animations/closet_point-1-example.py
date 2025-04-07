from splashkit import *

# Setup
window = splashkit.open_window("Closest Point on Line", 800, 600)

# Line endpoints
line_start = splashkit.point_2d(200, 100)
line_end = splashkit.point_2d(600, 500)

# Function to find closest point on a line segment
def closest_point_on_line(p, a, b):
    ap = splashkit.subtract(p, a)
    ab = splashkit.subtract(b, a)
    t = splashkit.dot_product(ap, ab) / splashkit.length_squared(ab)
    t = max(0, min(1, t))
    return splashkit.add(a, splashkit.multiply(ab, t))

# Main loop
while splashkit.window_is_open(window):
    splashkit.process_events()

    # Get mouse position
    mouse_pos = splashkit.mouse_position()

    # Find closest point on the line
    closest_point = closest_point_on_line(mouse_pos, line_start, line_end)

    # Clear the screen (white background)
    splashkit.clear_screen(splashkit.color_white())

    # Draw red line
    splashkit.draw_line(splashkit.color_red(), line_start.x, line_start.y, line_end.x, line_end.y)

    # Draw blue circle (mouse position)
    splashkit.draw_circle(splashkit.color_blue(), mouse_pos.x, mouse_pos.y, 50)

    # Draw green point (closest point on the line)
    splashkit.draw_circle(splashkit.color_green(), closest_point.x, closest_point.y, 5)

    # Refresh the window
    splashkit.refresh_window(window)

    # Limit to 60 FPS
    splashkit.delay(16)

# Close the window when done
splashkit.close_window(window)
