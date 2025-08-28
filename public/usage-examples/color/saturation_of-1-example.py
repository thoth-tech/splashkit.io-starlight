from splashkit import *
import random

open_window("Saturation Of", 800, 600)

random_red = random.randint(0, 255)
random_green = random.randint(0, 255)
random_blue = random.randint(0, 255)
color = rgba_color(random_red, random_green, random_blue, 255)
# Function used here ↓
color_saturation = saturation_of(color)
rectangle = rectangle_from(200, 100, 400, 300)

clear_screen(color_white())
fill_rectangle_record(color, rectangle)
draw_text_no_font_no_size("This color's saturation is " + str(color_saturation), color_black(), 235, 450)
draw_text_no_font_no_size("It's RGBA values are: R-" + str(random_red) + ", G-" + str(random_green) + ", B-" +str(random_blue) + ", A-255", color_black(), 235, 470)
refresh_screen()

delay(5000)

close_all_windows()