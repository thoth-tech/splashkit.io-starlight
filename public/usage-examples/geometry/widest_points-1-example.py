from splashkit import *

open_window("Widest Points on a Circle", 800, 600)

demo_circle = circle_at(point_at(400, 300), 120)

while not quit_requested():
    process_events()

    # Use the mouse position to define the direction vector
    center = center_point(demo_circle)
    mouse_pt = mouse_position()
    along = vector_point_to_point(center, mouse_pt)

    # Calculate the two points on the circle along the vector
    pt1 = point_at(0, 0)
    pt2 = point_at(0, 0)
    widest_points(demo_circle, along, pt1, pt2)

    clear_screen(color_white())

    # Draw the circle and the direction being tested
    draw_circle(color_black(), center.x, center.y, demo_circle.radius)
    draw_line(
        color_gray(),
        center.x, center.y,
        mouse_pt.x, mouse_pt.y
    )

    # Draw the widest points returned by the function
    draw_line(
        color_blue(),
        pt1.x, pt1.y,
        pt2.x, pt2.y
    )

    fill_circle(color_red(), pt1.x, pt1.y, 6)
    fill_circle(color_red(), pt2.x, pt2.y, 6)

    draw_text_no_font_no_size("Move the mouse to change the vector.", color_black(), 20, 20)
    draw_text_no_font_no_size("The red points are the widest points on the circle.", color_blue(), 20, 50)

    refresh_screen()