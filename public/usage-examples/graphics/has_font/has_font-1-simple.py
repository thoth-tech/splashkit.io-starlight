from splashkit import *

open_window("Has Font", 800, 600)
clear_screen()

# Check if the font exists
font_check = has_font("NORMAL_FONT")

# Display the text to show the result
if font_check:
    draw_text("Font found!", color_black(), 300, 300)
else:
    draw_text("Font not found!", color_black(), 300, 300)

refresh_screen()
delay(4000)
close_all_windows()


