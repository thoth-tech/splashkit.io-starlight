from splashkit import *

open_window("Widest points on a circle along a vector", 600, 600)

# Declare variables
circle_pt = screen_center()
circle = circle_at(circle_pt, 100)
mouse_pt = mouse_position()
direction_vector = None
widest_pt1 = None
widest_pt2 = None

while not quit_requested():
    process_events()

    # Get current mouse position
    mouse_pt = mouse_position()

    # Calculate the direction vector from the circle center to the mouse position
    direction_vector = vector_point_to_point(circle.center, mouse_pt)

    # Calculate the two widest points on the circle along the vector
    widest_pt1, widest_pt2 = widest_points(circle, direction_vector)

    # Draw everything
    clear_screen()
    draw_circle(color_black(), circle)
    fill_circle(color_blue(), mouse_pt.x, mouse_pt.y, 5)
    fill_circle(color_red(), widest_pt1.x, widest_pt1.y, 5)
    fill_circle(color_red(), widest_pt2.x, widest_pt2.y, 5)
    draw_line(color_green(), circle.center, mouse_pt)
    draw_line(color_red(), circle.center, widest_pt1)
    draw_line(color_red(), circle.center, widest_pt2)

    # Show calculation details
    draw_text(
        f"Mouse Position (Vector Direction): ({int(mouse_pt.x)}, {int(mouse_pt.y)})",
        color_black(), "Arial", 16, 10, 10
    )
    draw_text(
        f"Widest Point 1: ({int(widest_pt1.x)}, {int(widest_pt1.y)})",
        color_black(), "Arial", 16, 10, 35
    )
    draw_text(
        f"Widest Point 2: ({int(widest_pt2.x)}, {int(widest_pt2.y)})",
        color_black(), "Arial", 16, 10, 60
    )

    refresh_screen()

close_all_windows()
