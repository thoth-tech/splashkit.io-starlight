from splashkit import *

open_window("Circle Radius", 800, 600)
clear_screen(color_white())

# Set position for the circle
x_position = 400
y_position = 300

# Create a circle A at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Find the radius of the circle A
radius = circle_radius(A)

# Fill the circle
fill_circle(color_red(), x_position, y_position, radius)
# Use the radius to create a rectangle to cut 1/4 of the circle
fill_rectangle(color_white(), x_position, y_position , radius, radius)

text = "Radius: " + str(radius)
# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)

refresh_screen()
delay(4000)
close_all_windows()
