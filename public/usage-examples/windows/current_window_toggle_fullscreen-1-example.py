from splashkit import *

open_window("Presentation Mode", 800, 450)

while not quit_requested():
    process_events()

    # Toggling means the same key can both enter and leave fullscreen
    if key_typed(KeyCode.f_key):
        current_window_toggle_fullscreen()

    # Draw for the new state so the screen shows which mode the window is in
    if current_window_is_fullscreen():
        clear_screen(color_black())
        draw_text_font_as_string("Fullscreen mode", color_white(), "arial", 48, 40, 60)
        draw_text_font_as_string("Press F to leave fullscreen", color_light_gray(), "arial", 28, 40, 150)
    else:
        clear_screen(color_white())
        draw_text_font_as_string("Windowed mode", color_black(), "arial", 48, 40, 60)
        draw_text_font_as_string("Press F to enter fullscreen", color_dark_gray(), "arial", 28, 40, 150)

    refresh_screen_with_target_fps(60)

close_all_windows()
