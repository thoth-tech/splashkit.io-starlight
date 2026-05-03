from splashkit import *

open_window("Press B to Toggle Border", 700, 250)

while not quit_requested():
    process_events()

    if key_typed(KeyCode.b_key):
        current_window_toggle_border()

    border_state = "On" if current_window_has_border() else "Off"

    clear_screen(color_white())

    draw_text_no_font_no_size("Press B to toggle border", color_black(), 20, 20)
    draw_text_no_font_no_size(f"Border: {border_state}", color_blue(), 20, 80)

    refresh_screen()

close_all_windows()