from splashkit import *

open_window("Distance from Mouse to Line", 800, 600)

# Use one fixed line and let the mouse act as the test point
demo_line = line_from(150, 300, 650, 300)

while not quit_requested():
    process_events()

    # Measure how far the mouse point is from the line
    pt = mouse_position()
    distance = point_line_distance(pt, demo_line)

    clear_screen(color_white())

    # Draw the line, the point, and the measured distance
    draw_line(
        color_black(),
        demo_line.start_point.x, demo_line.start_point.y,
        demo_line.end_point.x, demo_line.end_point.y
    )

    fill_circle(color_red(), pt.x, pt.y, 6)

    draw_text_no_font_no_size("Move the mouse to change the point.", color_black(), 20, 20)
    draw_text_no_font_no_size("Distance from point to line: " + str(distance), color_blue(), 20, 50)

    refresh_screen()