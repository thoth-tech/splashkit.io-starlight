from splashkit import *

window = open_window("Closest Point On Line From Circle", 800, 600)

cursor_pos = Point2D 
circle_shape = circle_at(point_at(250, 150), 100)
line_shape = Line
closest_point_coordinates = Point2D

while (not quit_requested()):
    process_events()
    cursor_pos = mouse_position()
    line_shape = line_from_point_to_point(point_at(300, 400), cursor_pos)

    # Point2D variable stores the x and y coordinates of the closest point between the circle and line
    closest_point_coordinates = closest_point_on_line_from_circle(circle_shape, line_shape)

    clear_screen_to_white()
    draw_circle_record(color_black(), circle_shape)
    draw_line_record(color_black(), line_shape)
    fill_circle_record(color_red(), circle_at(closest_point_coordinates, 5))

    draw_text_no_font_no_size("Position of closest point on line from circle: " + point_to_string(closest_point_coordinates), color_black(), 110, 500)
    refresh_screen()

close_window(window)