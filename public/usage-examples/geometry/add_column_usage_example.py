from splashkit import *

open_window("Add Column Example", 600, 400)

load_font("Arial", "Arial.ttf")

start_x, start_y, column_height = 50, 50, 300
column_widths = [100, 200, 300]
column_labels = ["Small", "Medium", "Large"]

while not quit_requested():
    process_events()
    clear_screen(color_white())

    current_x = start_x
    for i in range(3):
        fill_rectangle(color_light_gray(), current_x, start_y, column_widths[i], column_height)
        draw_rectangle(color_black(), current_x, start_y, column_widths[i], column_height)
        # Using draw_text_font_as_string instead of draw_text
        draw_text_font_as_string(column_labels[i], color_black(), "Arial", 20, current_x + 10, start_y + 10)
        current_x += column_widths[i]

    refresh_screen()

close_all_windows()
free_all_fonts()