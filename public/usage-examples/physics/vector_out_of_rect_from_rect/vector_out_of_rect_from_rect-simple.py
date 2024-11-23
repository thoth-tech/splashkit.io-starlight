from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define the inner rectangle
inner_rectangle = Rectangle(125, 125, 50, 50)

# Define the outer rectangle
outer_rectangle = Rectangle(75, 75, 150, 150)

# Define velocity vector
velocity = Vector2D(10, 10)

# Calculate the escape vector
escape = vector_out_of_rect_from_rect(inner_rectangle, outer_rectangle, velocity)

# Define the origin point
origin = Point2D(150, 150)

# Create line representing the escape vector
vector_line = line_from(origin, escape)

# Clear the screen and draw shapes
clear_screen()
fill_rectangle(color_red(), outer_rectangle)
fill_rectangle(color_black(), inner_rectangle)

# Draw the escape vector line
draw_line(color_blue(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
