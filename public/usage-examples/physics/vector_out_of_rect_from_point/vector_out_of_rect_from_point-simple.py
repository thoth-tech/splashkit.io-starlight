from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define the outer rectangle
outer_rectangle = Rectangle()
outer_rectangle.x = 75
outer_rectangle.y = 75
outer_rectangle.width = 150
outer_rectangle.height = 150

# Define inner point
inner_point = Point2D()
inner_point.x = 150
inner_point.y = 150

# Define velocity vector
velocity = Vector2D()
velocity.x = 10
velocity.y = 10

# Calculate the escape vector
escape = vector_out_of_rect_from_point(inner_point, outer_rectangle, velocity)

vector_line = line_from_start_with_offset(inner_point, escape)

# Clear the screen and draw shapes
clear_screen(color_white())
fill_rectangle_record(color_black(), outer_rectangle)
fill_circle_record(color_yellow(), circle_at(inner_point,3))

# Draw the escape vector line
draw_line_record(color_red(), vector_line)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
