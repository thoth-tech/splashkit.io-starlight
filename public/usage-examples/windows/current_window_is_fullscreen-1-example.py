from splashkit import *

open_window("Fullscreen Checker", 800, 450)

while not quit_requested():
    process_events()

    # Give the player a way to change the state that we are about to check
    if key_typed(KeyCode.f_key):
        current_window_toggle_fullscreen()

    clear_screen_to_white()

    # Check every frame so the text always matches what the window is doing
    is_fullscreen = current_window_is_fullscreen()

    if is_fullscreen:
        draw_text_font_as_string("Fullscreen: true", color_black(), "arial", 48, 40, 60)
    else:
        draw_text_font_as_string("Fullscreen: false", color_black(), "arial", 48, 40, 60)

    draw_text_font_as_string("Press F to switch", color_dark_gray(), "arial", 28, 40, 150)

    refresh_screen_with_target_fps(60)

close_all_windows()
