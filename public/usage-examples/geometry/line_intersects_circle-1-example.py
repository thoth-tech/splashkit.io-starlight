from splashkit import *

open_window("Interaction of Line and Circle", 800, 600)

cursor_pos = Point2D()
line = Line
circle = Circle

while (not quit_requested()):
    process_events()

    #Defining line and circle
    cursor_pos = mouse_position()
    line = line_from_point_to_point(point_at(150, 100), cursor_pos)
    circle = circle_at_from_points(400, 300, 100)

    clear_screen(color_white())

    #Drawing line and circle
    draw_line_record(color_blue(), line)
    draw_circle_record(color_black(), circle)

    #Check for intersection and display results
    if (line_intersects_circle(line, circle)):
        draw_text_no_font_no_size("Line and Circle intersect", color_green(), 400, 100)
    else:
        draw_text_no_font_no_size("Line and Circle do not intersect", color_red(), 400, 100)
    
    refresh_screen()

close_all_windows()