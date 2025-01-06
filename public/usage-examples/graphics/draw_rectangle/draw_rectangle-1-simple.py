from splashkit import *

open_window("Draw Rectangle", 800, 600)
clear_screen(color_white())

for i in range(21):
    # Increase x position by 40 every round
    x = i * 40 - 40
    
    # Decrease y position by 30 every round
    y = 600 - i * 30

    random_color = rgb_color(
        rnd_range(0,255), rnd_range(0,255), rnd_range(0,255)   
    )

    # Draw rectangle base on the x, y position with width 40 and height 30
    draw_rectangle(random_color, x, y, 40, 30)

refresh_screen()
delay(4000)
close_all_windows()

