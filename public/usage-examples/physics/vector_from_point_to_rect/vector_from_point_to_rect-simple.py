from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define rectangles
test_rectangle_1 = Rectangle(50, 200, 50, 50)
test_rectangle_2 = Rectangle(200, 200, 50, 50)
test_rectangle_3 = Rectangle(200, 50, 50, 50)

# Define origin point
origin = Point2D(0, 0)

# Create vectors from origin to rectangles
my_vector_1 = vector_from_point_to_rect(origin, test_rectangle_1)
my_vector_2 = vector_from_point_to_rect(origin, test_rectangle_2)
my_vector_3 = vector_from_point_to_rect(origin, test_rectangle_3)

# Clear the screen
clear_screen()

# Draw rectangles
fill_rectangle(color_red(), test_rectangle_1)
fill_rectangle(color_blue(), test_rectangle_2)
fill_rectangle(color_purple(), test_rectangle_3)

# Draw lines representing vectors
draw_line(color_black(), line_from(my_vector_1))
draw_line(color_orange(), line_from(my_vector_2))
draw_line(color_brown(), line_from(my_vector_3))

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
