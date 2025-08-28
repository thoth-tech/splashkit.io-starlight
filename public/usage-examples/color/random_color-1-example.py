from splashkit import *

open_window("Random Color", 800, 600)

# Function used here ↓
color = random_color()
red_component = red_of(color)
green_component = green_of(color)
blue_component = blue_of(color)
alpha_component = alpha_of(color)
rectangle = rectangle_from(200, 100, 400, 300)

clear_screen(color_white())
fill_rectangle_record(color, rectangle)
draw_text_no_font_no_size("This random color's RGBA values are: R-" + str(red_component) + ", G-" + str(green_component) + ", B-" + str(blue_component) + ", A-" + str(alpha_component), color_black(), 160, 450)
refresh_screen()

delay(5000)

close_all_windows()