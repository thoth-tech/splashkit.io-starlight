from splashkit import *

# Let user create a triangle
write_line("Create a triangle!")
write_line("x1: ")
x1 = convert_to_integer(read_line())
write_line("y1: ")
y1 = convert_to_integer(read_line())
write_line("x2: ")
x2 = convert_to_integer(read_line())
write_line("y2: ")
y2 = convert_to_integer(read_line())
write_line("x3: ")
x3 = convert_to_integer(read_line())
write_line("y3: ")
y3 = convert_to_integer(read_line())

# Let user create a point
write_line("Create a ponow!")
write_line("x for point: ")
px1 = convert_to_integer(read_line())
write_line("y for point: ")
py1 = convert_to_integer(read_line())

open_window("PoIn Triangle", 800, 600)
clear_screen(color_white())

# Create the triangle base on the data given by user
A = triangle_from(point_at(x1, y1), point_at(x2, y2), point_at(x3, y3))

# Create the pobase on the data given by user
B = point_at(px1, py1)

# Draw the triangle
draw_triangle(color_red(), x1, y1, x2, y2, x3, y3)

# Draw the point
fill_circle(color_green(), px1, py1, 4)

# Detect if the poin the triangle or not
if point_in_triangle(B, A): 
    write_line("Poin the triangle!")
else:
    write_line("Ponot in the triangle!")
    
refresh_screen()
delay(4000)
close_all_windows()
