from splashkit import *

open_window("Draw Ellipse", 800, 600)
clear_screen(color_white())

for i in range(30):
    
    width = 600 - i * 20
    height = 400 - i * 10
    x = 100 + i * 10
    y = 100 + i * 5

    random_color = rgb_color(
        rnd_int(255), rnd_int(255), rnd_int(255)   
    )

    draw_ellipse(random_color, x, y, width, height)

refresh_screen()
delay(4000)
close_all_windows()

