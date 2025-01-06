from splashkit import *

#Let user enter the text
write_line("Type some text: ")
text = read_line()

#Let user enter the size
write_line("Enter the size for the text: ")
size = convert_to_integer(read_line())

open_window("Text width", 800, 600)
clear_screen(color_white())

# Load font
load_font("my_font", "arial.ttf")

# Calculate the text width with size enter by user
text_width = text_width(text, "my_font", size)

# Display the width of text
write_line("The width of the text is: " + str(text_width))

# Display the text in the window
draw_text(text, color_black(), "my_font", size, 100, 100)

refresh_screen()
delay(4000)
close_all_windows()