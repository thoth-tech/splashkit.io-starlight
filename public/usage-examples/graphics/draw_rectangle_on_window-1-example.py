from splashkit import *

# Open two windows side by side
red_window = open_window("Red Rectangles", 400, 300)
blue_window = open_window("Blue Rectangles", 400, 300)
move_window_to(blue_window, window_x(red_window) + window_width(red_window), window_y(red_window))

# Clear both windows
clear_window(red_window, color_white())
clear_window(blue_window, color_white())

# Draw red rectangles on the first window
for i in range(5):
    fill_rectangle_on_window(red_window, color_red(), 30 + i * 60, 80, 40, 100)

# Draw blue rectangles on the second window
for i in range(5):
    fill_rectangle_on_window(blue_window, color_blue(), 30 + i * 60, 80, 40, 100)

refresh_window(red_window)
refresh_window(blue_window)

delay(4000)

close_window(red_window)
close_window(blue_window)
