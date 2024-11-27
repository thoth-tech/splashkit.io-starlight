from splashkit import *

open_window("Point At", 800, 600)
clear_screen(color_white())

# Create a red circle at the point
fill_circle(color_red(), 400, 300, 4)

# Create a point at position (400,300)
point = point_at(400, 300)

refresh_screen()
delay(4000)
close_all_windows()




