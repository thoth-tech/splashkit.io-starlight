from splashkit import *

open_window("Mouse Shown", 800, 600)

while not quit_requested():
    process_events()

    # Press S to show the mouse, H to hide it
    if key_typed(KeyCode.s_key):
        show_mouse()

    if key_typed(KeyCode.h_key):
        hide_mouse()

    # mouse_shown returns true if the mouse cursor is currently visible
    if mouse_shown():
        status = "Mouse is visible"
    else:
        status = "Mouse is hidden"

    clear_screen(color_white())
    draw_text_font_as_string("Press S to show the mouse, H to hide it", color_black(), "Arial", 18, 170, 250)
    draw_text_font_as_string(status, color_blue(), "Arial", 24, 170, 290)
    refresh_screen_with_target_fps(60)

# Always show the mouse again before closing
show_mouse()
close_all_windows()
