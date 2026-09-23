from splashkit import *

display = display_details(0)
width = display_width(display)
    
open_window("How Wide is Your Screen?", width, 250)

font = font_named("Century.ttf")
text = f"The display is {width} pixels wide"

clear_screen_to_white()
fill_rectangle(color_black(), 0, screen_height() / 2, width, 1)
draw_text_no_font_no_size("<", color_black(), -2, screen_height() / 2 - 3)
draw_text_no_font_no_size(">", color_black(), width - 6, screen_height() / 2 - 3)
draw_text(text, color_black(), font, 30, (screen_width() / 2) - (text_width(text, font, 30) / 2), screen_height() / 2 - 60)
refresh_screen()

delay(5000)

close_all_windows()