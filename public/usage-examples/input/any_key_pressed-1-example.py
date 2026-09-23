from splashkit import *

open_window("Any Key Pressed", 800, 600)

message = "No key is being pressed."
circle_color = color_red()

while not quit_requested():
    process_events()

    if any_key_pressed():
        message = "A key is being pressed."
        circle_color = color_green()
    else:
        message = "No key is being pressed."
        circle_color = color_red()

    clear_screen(color_white())

    fill_circle(circle_color, 400, 250, 80)
    draw_text_no_font_no_size(message, color_black(), 240, 400)

    refresh_screen_with_target_fps(60)

close_all_windows()