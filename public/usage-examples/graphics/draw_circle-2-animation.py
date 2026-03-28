from splashkit import *

open_window("Circle Animation", 800, 600)

x = 0

while not window_close_requested("Circle Animation"):
    process_events()
    clear_screen(Color.WHITE)

    draw_circle(Color.RED, x, 300, 50)

    x += 2
    if x > 800:
        x = 0

    refresh_screen(60)