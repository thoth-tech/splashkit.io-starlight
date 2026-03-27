from splashkit import *

open_window("Mouse Position Display", 800, 600)

while not quit_requested():
    process_events()

    mouse_point = mouse_position()

    clear_screen(color_white())

    draw_text_no_font_no_size("Move the mouse to track its position in the window.", color_black(), 20, 20)
    draw_text_no_font_no_size("Mouse X: " + str(mouse_point.x), color_black(), 20, 60)
    draw_text_no_font_no_size("Mouse Y: " + str(mouse_point.y), color_black(), 20, 100)

    fill_circle(color_blue(), mouse_point.x, mouse_point.y, 8)
    draw_circle(color_black(), mouse_point.x, mouse_point.y, 8)

    refresh_screen(60)

close_all_windows()