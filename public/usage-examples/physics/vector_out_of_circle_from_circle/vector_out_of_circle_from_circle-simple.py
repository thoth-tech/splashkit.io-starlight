from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define outer and inner circles
outer_circle = Circle()
outer_circle.center = Point2D()
outer_circle.center.x = 150
outer_circle.center.y = 150
outer_circle.radius = 75

# Define inner circle
inner_circle = Circle()
inner_circle.center = Point2D()
inner_circle.center.x = 150
inner_circle.center.y = 150
inner_circle.radius = 25

# Define velocity vector
velocity = Vector2D()
velocity.x = 10
velocity.y = 10

# Calculate escape vector
escape = vector_out_of_circle_from_circle(inner_circle, outer_circle, velocity)

# Create line representing the escape vector
vector_line = line_from_start_with_offset(inner_circle.center, escape)

# Clear the screen and draw shapes
clear_screen(color_white())
fill_circle_record(color_black(), outer_circle)
fill_circle_record(color_yellow(), inner_circle)

# Draw the escape vector line
draw_line_record(color_red(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
