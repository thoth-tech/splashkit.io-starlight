from splashkit import *

open_window("Color Bright Green", 300, 540)

clear_screen(color_white())

# The body of the traffic light
fill_rectangle(color_black(), 60, 40, 180, 420)

# The red and amber lights are switched off, so they are drawn dark gray
fill_circle(color_dark_gray(), 150, 110, 50)
fill_circle(color_dark_gray(), 150, 250, 50)

# The green light is on - color_bright_green stands out against the black body
# Function used here ↓
fill_circle(color_bright_green(), 150, 390, 50)

draw_text_no_font_no_size("GO - color_bright_green", color_bright_green(), 70, 490)

refresh_screen()

delay(5000)

close_all_windows()
