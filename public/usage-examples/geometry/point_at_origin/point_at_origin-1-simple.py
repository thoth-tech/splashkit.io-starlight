from splashkit import *

open_window("Point At Origin", 800, 600)
clear_screen(color_white())

# Create a point at origin
point = point_at_origin()

# Create a red circle at the origin
fill_circle(color_red(), point.x, point.y, 4)

refresh_screen()
delay(4000)
close_all_windows()




