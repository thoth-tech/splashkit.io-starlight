from splashkit import *
import random

open_window("Draw Triangle", 800, 600)
clear_screen(color_white())

for i in range(10):
    
    x1 = random.randint(0,800)
    y1 = random.randint(0,600)
    x2 = random.randint(0,800)
    y2 = random.randint(0,600)
    x3 = random.randint(0,800)
    y3 = random.randint(0,600)

    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)   
    )

    draw_triangle(random_color, x1, y1, x2, y2, x3, y3)

refresh_screen()
delay(4000)
close_all_windows()

