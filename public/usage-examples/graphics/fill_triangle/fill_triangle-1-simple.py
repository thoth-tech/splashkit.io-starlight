from splashkit import *

open_window("Fill triangle", 800, 600)

fill_triangle(color_red(), 100, 100, 200, 200, 300, 100)
refresh_screen()

delay(5000)
close_all_windows()