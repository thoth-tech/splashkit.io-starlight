from splashkit import *

open_window("Text Width", 800, 600)
clear_screen(color_white())

text = "Text Width!"

# Load font
load_font("my_font", "arial.ttf")

# Calculate the text width, 0 for arial.ttf, and 16 is the font size
text_width = text_width(text, "my_font", 16)

# Calculate the x and y position to make the text in the centre of the window
x_position = (800 - text_width) // 2
y_position = 600 // 2

# Display the text in the centre of the window
draw_text(text, color_black(), 0, 16, x_position, y_position)


refresh_screen()
delay(4000)
close_all_windows()
