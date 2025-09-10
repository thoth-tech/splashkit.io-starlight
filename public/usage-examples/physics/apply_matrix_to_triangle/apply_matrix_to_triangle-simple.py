from splashkit import *

# Open the window
open_window("Apply Matrix to Triangle", 300, 300)

# Clear the screen
clear_screen(color_white())

# Define the triangle points
top = Point2D()
top.x = 150
top.y = 150

left = Point2D()
left.x = 80
left.y = 220

right = Point2D()
right.x = 220
right.y = 220

test_triangle_1 = Triangle()
test_triangle_1.points[0] = top
test_triangle_1.points[1] = left
test_triangle_1.points[2] = right

# Define the transformation matrix (scaling + translation)
scaling_matrix = scale_matrix(0.5)
trans_matrix = translation_matrix(-25, 50)
my_matrix_1 = matrix_multiply_matrix(scaling_matrix, trans_matrix)

# Draw the initial triangle
fill_triangle_record(color_black(), test_triangle_1)
write_line("Triangle points before matrix application:")
for i in range(3):
    write_line(point_to_string(test_triangle_1.points[i]))

# Apply the matrix to the triangle
apply_matrix_to_triangle(my_matrix_1, test_triangle_1)

# Draw the transformed triangle
fill_triangle_record(color_red(), test_triangle_1)
write_line("Triangle points after matrix application:")
for i in range(3):
    write_line(point_to_string(test_triangle_1.points[i]))

# Refresh the screen and wait
refresh_screen()
delay(4000)

# Close all windows
close_all_windows()
