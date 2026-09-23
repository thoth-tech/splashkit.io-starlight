from splashkit import *

open_window("Current Window Width", 800, 600)

while not quit_requested():
    process_events()

    window_width = current_window_width()

    clear_screen(color_white())

    draw_text_no_font_no_size("Current window width:", color_black(), 220, 220)
    draw_text_no_font_no_size(str(window_width) + " pixels", color_blue(), 260, 270)

    refresh_screen_with_target_fps(60)

close_all_windows()