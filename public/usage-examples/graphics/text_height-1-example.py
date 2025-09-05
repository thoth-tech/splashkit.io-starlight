from splashkit import *

open_window("Text Height", 800, 600)

text_font = font_named("Century.ttf")
text_string = "Example text"
# Change the below value to affect the text's height
text_font_size = 100
# Function used here ↓
height = text_height(text_string, text_font, text_font_size)
l = line_from(30, 200, 30, 200 + height)

clear_screen(color_white())
draw_text(text_string, color_black(), text_font, text_font_size, 50, 200)
draw_line_record(color_black(), l)
fill_triangle(color_black(), l.start_point.x, l.start_point.y, l.start_point.x - 7, l.start_point.y + 7, l.start_point.x + 7, l.start_point.y + 7)
fill_triangle(color_black(), l.end_point.x, l.end_point.y, l.end_point.x + 7, l.end_point.y - 7, l.end_point.x - 7, l.end_point.y - 7)
draw_text_no_font_no_size(f"This text is {height} pixels tall", color_black(), 30, 220 + height)
refresh_screen()

delay(5000)

close_all_windows()