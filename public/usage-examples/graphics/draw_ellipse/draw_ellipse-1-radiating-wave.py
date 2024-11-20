from splashkit import *
import random

open_window("Draw Ellipse", 800, 600)
clear_screen(color_white())

for i in range(30):
    
    width = 600 - i * 20
    height = 400 - i * 10
    x = 100 + i * 10
    y = 100 + i * 5

    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)   
    )

    draw_ellipse(random_color, x, y, width, height)

refresh_screen()
delay(4000)
close_all_windows()

