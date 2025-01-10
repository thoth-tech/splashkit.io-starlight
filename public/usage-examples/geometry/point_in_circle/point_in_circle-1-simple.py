from splashkit import *

# Let user create a circle
write_line("Create a circle!")
write_line("Center point x1: ")
x1 = convert_to_integer(read_line())
write_line("Center point y1: ")
y1 = convert_to_integer(read_line())
write_line("Radius for circle: ")
radius = convert_to_integer(read_line())

# Let user create a point
write_line("Create a ponow!")
write_line("x for point: ")
px1 = convert_to_integer(read_line())
write_line("y for point: ")
py1 = convert_to_integer(read_line())

open_window("Point In circle", 800, 600)
clear_screen(color_white())

# Create the circle base on the data given by user
A = circle_at(point_at(x1, y1), radius)

# Create the pobase on the data given by user
B = point_at(px1, py1)

# Draw the circle
draw_circle(color_red(), x1, y1, radius)

# Draw the point
fill_circle(color_green(), px1, py1, 4)

# Detect if the poin the circle or not
if point_in_circle(B, A): 
    write_line("Point in the circle!")
else:
    write_line("Point not in the circle!")
    
refresh_screen()
delay(4000)
close_all_windows()
