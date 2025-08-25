from splashkit import *

open_window("Screen Width", 800, 600)

width = screen_width()
text = f"The screen is {width} pixels wide"

clear_screen_to_white()
fill_rectangle(color_black(), 0, screen_height() / 2, width, 1)
draw_text_no_font_no_size("<", color_black(), -2, screen_height() / 2 - 3)
draw_text_no_font_no_size(">", color_black(), width - 6, screen_height() / 2 - 3)
draw_text_no_font_no_size(text, color_black(), (width / 2) - (text_width(text, 0, 0) / 2), screen_height() / 2 - 20)
refresh_screen()

delay(5000)

close_all_windows()