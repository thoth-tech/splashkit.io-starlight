from splashkit import *

open_window("Text Width", 680, 200)
clear_screen(color_white())

load_font("LOTR", "lotr.TTF");
set_font_style("LOTR", font_style.bold_font)
draw_text("Ringbearer", color_black(), "LOTR", 100, 30, 20)

width = text_width_font_named("Ringbearer", "LOTR", 100)
draw_rectangle(color_black(), 30, 130, width, 10)
refresh_screen()

delay(5000)
close_all_windows()