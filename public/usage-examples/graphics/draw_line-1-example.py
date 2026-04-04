from splashkit import *

open_window("Draw Line Example", 800, 600)

while not quit_requested():
    process_events()
    clear_screen_to_white()

    draw_line(color_red(), 100, 100, 700, 500)

    refresh_screen_with_target_fps(60)