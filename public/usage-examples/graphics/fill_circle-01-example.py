from splashkit import *

open_window("Drawing Example", 800, 600)
while not quit_requested():
    process_events()
    clear_screen(color_white())
    fill_circle(color_blue(), 400, 300, 50)
    fill_rectangle(color_red(), 100, 100, 150, 80)
    draw_line(color_green(), 50, 50, 750, 550)
    refresh_screen()
