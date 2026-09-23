from splashkit import *

open_window("Circle Animation", 800, 600)

x = 0

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Move the circle across the screen and wrap around
    draw_circle(color_red(), x, 300, 50)

    x += 2
    if x > 800:
        x = 0

    refresh_screen_with_target_fps(60)

close_all_windows()
