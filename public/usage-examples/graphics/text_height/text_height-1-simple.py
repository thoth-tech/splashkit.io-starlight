from splashkit import *

# Open a window
open_window("Text Height", 800, 600)

# Clear the screen to a black background
clear_screen(color_white())

# Text to display
text = "Text Height!"

# Calculate the text height with Normal font '0' and size 16
text_width = text_width(text, 0, 16)

# Calculate the y position to make the text in the centre of the window
x_position = (800 - text_width) // 2
y_position = 600 // 2

# Display the text in the centre of the window
draw_text(text, color_black(), 0, 16, x_position, y_position)


refresh_screen()
delay(4000)
close_all_windows()
