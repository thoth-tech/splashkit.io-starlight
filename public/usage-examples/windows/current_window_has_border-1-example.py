from splashkit import *

open_window("Current Window Has Border", 800, 600)

while not quit_requested():
    process_events()

    # Press B to toggle the current window border
    if key_typed(KeyCode.b_key):
        current_window_toggle_border()

    # Check whether the current window has a border
    has_border = current_window_has_border()

    clear_screen(color_white())

    # Show the current border state on screen
    draw_text_no_font_no_size("Press B to toggle the window border.", color_black(), 170, 220)

    if has_border:
        draw_text_no_font_no_size("Current window has a border", color_green(), 210, 280)
    else:
        draw_text_no_font_no_size("Current window does not have a border", color_red(), 150, 280)

    refresh_screen_with_target_fps(60)

close_all_windows()