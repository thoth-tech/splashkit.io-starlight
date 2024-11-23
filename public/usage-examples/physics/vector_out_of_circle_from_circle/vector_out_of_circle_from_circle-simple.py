from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define outer and inner circles
outer_circle = Circle(Point2D(150, 150), 75)
inner_circle = Circle(Point2D(150, 150), 25)

# Define velocity vector
velocity = Vector2D(10, 10)

# Calculate escape vector
escape = vector_out_of_circle_from_circle(inner_circle, outer_circle, velocity)

# Create line representing the escape vector
vector_line = line_from(inner_circle.center, escape)

# Clear the screen and draw shapes
clear_screen()
fill_circle(color_black(), outer_circle)
fill_circle(color_yellow(), inner_circle)

# Draw the escape vector line
draw_line(color_red(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
