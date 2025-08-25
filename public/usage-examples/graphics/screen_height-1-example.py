from splashkit import *

open_window("Screen Height", 800, 600)

height = screen_height()
text = f"The screen is {height} pixels tall"

clear_screen_to_white()
fill_rectangle(color_black(), screen_width() / 2, 0, 1, height)
draw_text_no_font_no_size("^", color_black(), screen_width() / 2 - 3, 0)
draw_text_no_font_no_size("V", color_black(), screen_width() / 2 - 3, height - 8)
draw_text_no_font_no_size(text, color_black(), screen_width() / 2 + 20, screen_height() / 2)
refresh_screen()

delay(5000)

close_all_windows()