from splashkit import *

my_window = open_window("Fill Triangle On Window", 800, 600)

# Define a triangle to draw
tri = triangle_from__from_coordinates(300, 250, 500, 250, 400, 350)

# Fill triangle on the window and refresh
fill_triangle_on_window_record(my_window, color_blue(), tri)
refresh_window(my_window)

delay(3000)
close_window(my_window)
