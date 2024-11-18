from splashkit import *
import random

my_window = open_window("Draw Circle on Window", 800, 600)
clear_screen(color_white())

for _ in range(50):
    x = random.randint(0, 800)
    y = random.randint(0, 600)
    radius = random.randint(0, 50)

    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)   
    )

    draw_circle_on_window(my_window, random_color, x, y, radius)

refresh_screen()
delay(4000)
close_all_windows()
