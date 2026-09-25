from splashkit import *

open_window("Window Has Focus", 800, 600)

while not quit_requested():
    process_events()

    # Check whether the current window has focus
    has_focus = window_has_focus(current_window())

    clear_screen(color_white())

    # Show the current focus state on screen
    draw_text_no_font_no_size("Click on or away from the window to change focus.", color_black(), 120, 220)

    if has_focus:
        draw_text_no_font_no_size("Window has focus", color_green(), 280, 280)
    else:
        draw_text_no_font_no_size("Window does not have focus", color_red(), 240, 280)

    refresh_screen_with_target_fps(60)

close_all_windows()