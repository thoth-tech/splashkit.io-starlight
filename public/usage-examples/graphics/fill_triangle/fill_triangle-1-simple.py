from splashkit import *

my_window = open_window("Simple Red Triangle", 800, 600)

tria = triangle_from(100, 100, 200, 200, 300, 100)

fill_triangle(my_window, color_blue(), tria)
refresh_window(my_window)

delay(3000)
close_window(my_window)