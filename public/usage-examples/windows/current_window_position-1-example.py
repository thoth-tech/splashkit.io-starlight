from splashkit import *

open_window("Live Window Position Monitor", 700, 250)

while not quit_requested():
    process_events()

    pos = current_window_position()
    x = current_window_x()
    y = current_window_y()

    clear_screen(color_white())

    draw_text_no_font_no_size("Move the window to see the values update", color_black(), 20, 20)
    draw_text_no_font_no_size(f"Current Window Position: ({int(pos.x)}, {int(pos.y)})", color_blue(), 20, 70)
    draw_text_no_font_no_size(f"Current Window X: {x}", color_red(), 20, 110)
    draw_text_no_font_no_size(f"Current Window Y: {y}", color_green(), 20, 150)

    refresh_screen()

close_all_windows()