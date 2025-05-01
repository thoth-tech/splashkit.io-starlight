from splashkit import *

open_window("Interactive Line on Graph", 800, 600)

user_line = Line
x_axis_line = Line
y_axis_line = Line
cursor_pos = Point2D()
vector = Vector2D()

while (not quit_requested()):
    process_events()
    
    cursor_pos = mouse_position()
    user_line = line_from_point_to_point(point_at(400, 350), cursor_pos)

    x_axis_line = line_from_point_to_point(point_at(cursor_pos.x, 350), point_at(400, 350))
    y_axis_line = line_from_point_to_point(point_at(400, cursor_pos.y), point_at(400, 350))

    # The line normal of the desired line is stored under the vector 2d variable
    vector = line_normal(user_line)

    clear_screen_to_white()
    draw_line_record(color_black(), user_line)
    draw_line_record(color_red(), x_axis_line)
    draw_line_record(color_red(), y_axis_line)
    draw_text_no_font_no_size("The black line's normal is: " + str(vector.x) + "," + str(vector.y) , color_black(), 60, 500)

    refresh_screen()
    
close_all_windows()