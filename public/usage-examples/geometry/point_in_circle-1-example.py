from splashkit import *

open_window("Circular Toggle Button", 800, 600)

while (not quit_requested()):
    process_events()

    #Declaring the variables
    circle_color = Color
    cursor_pos = mouse_position()
    circle = circle_at_from_points(400, 300, 80)

    clear_screen(color_white())

    if (point_in_circle(cursor_pos, circle)):
        circle_color = color_green()
        draw_text_no_font_no_size("Point is in the circle", color_green(), 300, 100)
    else:
        circle_color = color_bright_green()
        draw_text_no_font_no_size("Point is not in the circle", color_red(), 300, 100)

    fill_circle_record(circle_color, circle)
    draw_text_no_font_no_size("Button", color_black(), 375, 300)

    refresh_screen()

close_all_windows()