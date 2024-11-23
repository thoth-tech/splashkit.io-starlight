from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define the outer rectangle
outer_rectangle = Rectangle(75, 75, 150, 150)

# Define the escape point
escape_point = Point2D(150, 150)

# Define velocity vector
velocity = Vector2D(10, 10)

# Calculate the escape vector
escape = vector_out_of_rect_from_point(escape_point, outer_rectangle, velocity)

# Create line representing the escape vector
vector_line = line_from(escape_point, escape)

# Clear the screen and draw shapes
clear_screen()
fill_rectangle(color_black(), outer_rectangle)
fill_circle(color_yellow(), circle_at(escape_point, 3))

# Draw the escape vector line
draw_line(color_red(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
