from splashkit import *

open_window("Text Example", 800, 600)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    draw_text("Hello SplashKit!", color_black(), 300, 250)

    refresh_screen()