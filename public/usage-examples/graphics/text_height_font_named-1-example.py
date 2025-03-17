from splashkit import *

open_window("Text Height", 680, 200)
clear_screen(color_white())

load_font("LOTR", "lotr.TTF");
set_font_style("LOTR", font_style.bold_font)
draw_text("Ringbearer", color_black(), "LOTR", 100, 30, 20)

height = text_height_font_named("Ringbearer", "LOTR", 100)
draw_rectangle(color_black(), 20, 20, 20, height)
refresh_screen()

delay(5000)
close_all_windows()