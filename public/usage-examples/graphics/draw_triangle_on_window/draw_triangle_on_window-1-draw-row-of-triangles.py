from splashkit import *

my_window = open_window("Draw Triangle on Window", 800, 600)
clear_screen(color_white())

for i in range(20):
    x = 40 * i

    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)   
    )

    draw_triangle_on_window(my_window, random_color, 0 + x, 0, 20 + x, 40, 40 + x, 0)

refresh_screen()
delay(4000)
close_all_windows()


