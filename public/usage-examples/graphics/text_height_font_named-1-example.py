from splashkit import *

open_window("Text Height", 680, 200)
clear_screen(color_white())

load_font("LOTR", "lotr.TTF")
set_font_style_name_as_string("LOTR", font_style.bold_font)
draw_text_font_as_string("Ringbearer", color_black(), "LOTR", 100, 30, 20)

#Getting the height of the text to fill a rectange of that height
height = text_height_font_named("Ringbearer", "LOTR", 100)
fill_rectangle(color_black(), 20, 20, 10, height)
refresh_screen()

delay(5000)
close_all_windows()