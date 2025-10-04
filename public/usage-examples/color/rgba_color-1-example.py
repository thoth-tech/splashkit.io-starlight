from splashkit import *
import random

open_window("Draw Rectangle with Random Color", 800, 600)

random_red = random.randint(0, 255)
random_green = random.randint(0, 255)
random_blue = random.randint(0, 255)
# The function creates a color which is saved to a color variable. In this example a random red, green and blue value is inputted. Alpha/opacity is also set to the maximum
color = rgba_color(random_red, random_green, random_blue, 255)
rectangle = rectangle_from(200, 100, 400, 300)

clear_screen(color_white())
fill_rectangle_record(color, rectangle)
# Show RGBA values of the randomly generated color
draw_text_no_font_no_size("Current color details: R-" + str(random_red) + ", G-" + str(random_green) + ", B-" +str(random_blue), color_black(), 235, 450)
refresh_screen()

delay(5000)

close_all_windows()