from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define rectangles
test_rectangle_1 = Rectangle()
test_rectangle_1.x = 50
test_rectangle_1.y = 200
test_rectangle_1.width = 50
test_rectangle_1.height = 50

test_rectangle_2 = Rectangle()
test_rectangle_2.x = 200
test_rectangle_2.y = 200
test_rectangle_2.width = 50
test_rectangle_2.height = 50

test_rectangle_3 = Rectangle()
test_rectangle_3.x = 200
test_rectangle_3.y = 50
test_rectangle_3.width = 50
test_rectangle_3.height = 50

# Define origin point
origin = Point2D()
origin.x = 0
origin.y = 0

# Create vectors from origin to rectangles
my_vector_1 = vector_from_point_to_rect(origin, test_rectangle_1)
my_vector_2 = vector_from_point_to_rect(origin, test_rectangle_2)
my_vector_3 = vector_from_point_to_rect(origin, test_rectangle_3)

# Clear the screen
clear_screen(color_white())

# Draw rectangles
fill_rectangle_record(color_red(), test_rectangle_1)
fill_rectangle_record(color_blue(), test_rectangle_2)
fill_rectangle_record(color_purple(), test_rectangle_3)

# Draw lines representing vectors
draw_line_record(color_black(), line_from_vector(my_vector_1))
draw_line_record(color_orange(), line_from_vector(my_vector_2))
draw_line_record(color_brown(), line_from_vector(my_vector_3))

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
