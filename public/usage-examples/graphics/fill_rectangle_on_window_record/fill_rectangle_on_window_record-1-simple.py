from splashkit import *

my_window = open_window("Fill Rectangle On Window", 800, 600)

# Define a rectangle to draw
rect = rectangle_from(300, 250, 200, 100)  # x, y, width, height

# Fill rectangle on the window and refresh
fill_rectangle_on_window_record(my_window, color_blue(), rect)
refresh_window(my_window)

delay(3000)
close_window(my_window)
