from splashkit import *

open_window("Line Intersects Circle", 800, 600)

# Create a circle at the center of the window
center = point_at(400, 300)
demo_circle = circle_at(center, 120)

while not quit_requested():
    process_events()

    # Create a line from a fixed point to the mouse position
    start_pt = point_at(100, 300)
    end_pt = mouse_position()

    demo_line = line_from(
        start_pt.x, start_pt.y,
        end_pt.x, end_pt.y
    )

    # Check if the line intersects the circle
    intersects = line_intersects_circle(demo_line, demo_circle)

    clear_screen(color_white())

    # Draw the circle
    draw_circle(color_black(), center.x, center.y, demo_circle.radius)

    # Draw the line based on intersection result
    if intersects:
        line_color = color_green()
        message = "The line intersects the circle."
    else:
        line_color = color_red()
        message = "The line does not intersect the circle."

    draw_line(
        line_color,
        demo_line.start_point.x,
        demo_line.start_point.y,
        demo_line.end_point.x,
        demo_line.end_point.y
    )

    draw_text_no_font_no_size(message, line_color, 20, 20)

    refresh_screen()