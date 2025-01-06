from splashkit import *

open_window("Draw Triangle", 800, 600)
clear_screen(color_white())

for i in range(10):
    # Random point 1 for the trangle (x1,y1)
    x1 = rnd_range(0,800)
    y1 = rnd_range(0,600)
    
    # Random point 2 for the trangle (x2,y2)
    x2 = rnd_range(0,800)
    y2 = rnd_range(0,600)
    
    # Random point 3 for the trangle (x3,y3)
    x3 = rnd_range(0,800)
    y3 = rnd_range(0,600)

    random_color = rgb_color(
        rnd_range(0, 255), rnd_range(0, 255), rnd_range(0, 255)   
    )

    # Draw trangle base on the three random points
    draw_triangle(random_color, x1, y1, x2, y2, x3, y3)

refresh_screen()
delay(4000)
close_all_windows()

