from splashkit import *

open_window("Screen Height", 800, 600)

height = screen_height()
l = line_from(screen_width() / 2, 0, screen_width() / 2, height)
text = f"The screen is {height} pixels tall"

clear_screen(color_white())
draw_line_record(color_black(), l)
fill_triangle(color_black(), l.start_point.x, l.start_point.y, l.start_point.x - 10, l.start_point.y + 10, l.start_point.x + 10, l.start_point.y + 10)
fill_triangle(color_black(), l.end_point.x, l.end_point.y, l.end_point.x + 10, l.end_point.y - 10, l.end_point.x - 10, l.end_point.y - 10)
draw_text_no_font_no_size(text, color_black(), screen_width() / 2 + 20, screen_height() / 2)
refresh_screen()

delay(5000)

close_all_windows()