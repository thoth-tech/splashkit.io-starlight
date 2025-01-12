from splashkit import *

window = open_window("Draw Circle on Window", 800, 600)
clear_screen(color_white())

for _ in range(50):
    
    # Set random x position to 1 - 800
    x = rnd_range(0, 800)
    
    # Set random y position to 1 - 600
    y = rnd_range(0, 600)
    
    # Set random radius to 1 - 50
    radius = rnd_range(0, 50)

    random_color = rgb_color(
        rnd_range(0, 255), rnd_range(0, 255), rnd_range(0, 255)   
    )

    # Draw the circle base on the random data
    draw_circle_on_window(window, random_color, x, y, radius)

refresh_screen()
delay(4000)
close_all_windows()
