from splashkit import *

open_window("Distant Point On Circle", 800, 600)

cursor_pos = Point2D 
circle_shape = circle_at(point_at(400, 200), 100)
distant_point_coordinates = Point2D

while (not quit_requested()):
    process_events()

    cursor_pos = mouse_position()

    # Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
    distant_point_coordinates = distant_point_on_circle(cursor_pos, circle_shape)

    clear_screen_to_white()
    draw_circle_record(color_black(), circle_shape)
    fill_circle_record(color_red(), circle_at(distant_point_coordinates, 5))
    draw_text_no_font_no_size(f"Most distant point on circle's circumference from mouse cursor is: {distant_point_coordinates.x:.0f}, {distant_point_coordinates.y:.0f}", color_black(), 100, 500)
    
    refresh_screen()

close_all_windows()