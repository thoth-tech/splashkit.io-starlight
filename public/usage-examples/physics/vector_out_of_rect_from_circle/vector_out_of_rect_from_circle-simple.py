from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define the outer rectangle
outer_rectangle = Rectangle(75, 75, 150, 150)

# Define the inner circle
inner_circle = Circle(Point2D(150, 150), 25)

# Define the velocity vector
velocity = Vector2D(10, 10)

# Calculate the escape vector
escape = vector_out_of_rect_from_circle(inner_circle, outer_rectangle, velocity)

# Create a line representing the escape vector
vector_line = line_from(inner_circle.center, escape)

# Clear the screen and draw shapes
clear_screen()
fill_rectangle(color_black(), outer_rectangle)
fill_circle(color_yellow(), inner_circle)

# Draw the escape vector line
draw_line(color_red(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
