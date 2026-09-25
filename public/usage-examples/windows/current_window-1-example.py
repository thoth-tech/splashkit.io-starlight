from splashkit import *

display_window = open_window("Current Window Example", 800, 600)

while not quit_requested():
    process_events()

    display_window = current_window()

    width = window_width(display_window)
    height = window_height(display_window)
    caption = window_caption(display_window)
    current_status = str(is_current_window(display_window))

    clear_window(display_window, color_white())

    draw_text_no_font_no_size("Using current_window()", color_black(), 20, 20)
    draw_text_no_font_no_size("Caption: " + caption, color_black(), 20, 60)
    draw_text_no_font_no_size("Window Width: " + str(width), color_black(), 20, 100)
    draw_text_no_font_no_size("Window Height: " + str(height), color_black(), 20, 140)
    draw_text_no_font_no_size("Is Current Window: " + current_status, color_black(), 20, 180)

    fill_rectangle(color_blue(), 20, 230, width - 40, 80)
    draw_text_no_font_no_size("This rectangle is drawn in the current window.", color_white(), 40, 260)

    refresh_window_with_target_fps(display_window, 60)

close_window(display_window)