from splashkit import *

# Let user enter the radius
write_line("Enter Radius for circle: ")
Radius = convert_to_double(read_line())

open_window("Circle Radius", 800, 600)
clear_screen(color_white())

# Create a circle at the position (400,300)
circle = circle_at(point_at(400,300), Radius)

# Find the radius of the circle 
radius = circle_radius(circle)

# Fill the circle
fill_circle(color_red(), 400,300, radius)

# Create a rectangle to show the radius
draw_rectangle(color_white(), 400,300 , radius, radius)

text = "Radius: " + str(radius)

# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)

refresh_screen()
delay(4000)
close_all_windows()
