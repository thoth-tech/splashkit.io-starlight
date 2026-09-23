from splashkit import *

open_window("Key Down Example", 800, 600)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    if key_down(SPACE_KEY):
        draw_text("Space key is pressed", color_black(), 200, 300)
    else:
        draw_text("Press the space key", color_black(), 200, 300)

    refresh_screen()
