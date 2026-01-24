from splashkit import *

open_window("Mouse Example", 800, 600)
while not quit_requested():
    process_events()
    clear_screen(color_white())
    draw_text("Mouse X: " + str(mouse_x()), color_black(), 20, 20)
    draw_text("Mouse Y: " + str(mouse_y()), color_black(), 20, 45)
    refresh_screen()
