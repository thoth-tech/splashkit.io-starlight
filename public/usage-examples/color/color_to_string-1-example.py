from splashkit import *

open_window("Color To String", 800, 450)

colors = [color_red(), color_green(), color_blue(), color_orange(), color_purple()]
labels = ["Red", "Green", "Blue", "Orange", "Purple"]
rect_width = 120
rect_height = 200
start_x = 60
start_y = 130
gap = 20

clear_screen(color_white())

draw_text_no_font_no_size("Color To String", color_black(), 315, 50)
draw_text_no_font_no_size("Each colour displayed with its hex string value", color_black(), 220, 75)

for i in range(5):
    x = start_x + i * (rect_width + gap)

    fill_rectangle(colors[i], x, start_y, rect_width, rect_height)

    # Function used here ↓
    hex_str = color_to_string(colors[i])
    draw_text_no_font_no_size(labels[i], color_black(), x + 30, start_y + rect_height + 10)
    draw_text_no_font_no_size(hex_str, color_black(), x + 5, start_y + rect_height + 28)

refresh_screen()
delay(5000)

close_all_windows()
