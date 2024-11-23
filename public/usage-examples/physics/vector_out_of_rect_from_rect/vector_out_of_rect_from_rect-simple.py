from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define the inner rectangle
inner_rectangle = Rectangle()
inner_rectangle.x = 125
inner_rectangle.y = 125
inner_rectangle.width = 50
inner_rectangle.height = 50

# Define the outer rectangle
outer_rectangle = Rectangle()
outer_rectangle.x = 75
outer_rectangle.y = 75
outer_rectangle.width = 150
outer_rectangle.height = 150

# Define velocity vector
velocity = Vector2D()
velocity.x = 10
velocity.y = 10

# Calculate the escape vector
escape = vector_out_of_rect_from_rect(inner_rectangle, outer_rectangle, velocity)

# Define the origin point
origin = Point2D()
origin.x = 150
origin.y = 150

# Create line representing the escape vector
vector_line = line_from_start_with_offset(origin, escape)

# Clear the screen and draw shapes
clear_screen(color_white())
fill_rectangle_record(color_red(), outer_rectangle)
fill_rectangle_record(color_black(), inner_rectangle)

# Draw the escape vector line
draw_line_record(color_blue(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
