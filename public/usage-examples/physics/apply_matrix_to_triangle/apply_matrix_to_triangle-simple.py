from splashkit import *

# Open the window
open_window("Apply Matrix", 300, 300)

# Clear the screen
clear_screen(color_white())

# Define the triangle points
test_triangle_1 = Triangle()
top = Point2D()
top.x = 150
top.y = 150

left = Point2D()
left.x = 130
left.y = 170

right = Point2D()
right.x = 170
right.y = 170

test_triangle_1.points[0] = top
test_triangle_1.points[1] = left
test_triangle_1.points[2] = right

# Create and populate the matrix
my_matrix_1 = Matrix2D()
for i in range(3):
    for j in range(3):
        my_matrix_1.elements[i][j] = 0.5

# Draw the initial triangle
draw_triangle(color_black(), test_triangle_1)
write_line("Triangle points before matrix application:")
for point in test_triangle_1.points:
    write_line(point_to_string(point))

# Apply the matrix to the triangle
apply_matrix(my_matrix_1, test_triangle_1)

# Draw the transformed triangle
draw_triangle(color_red(), test_triangle_1)
write_line("Triangle points after matrix application:")
for point in test_triangle_1.points:
    write_line(point_to_string(point))

# Refresh the screen and wait
refresh_screen()
delay(4000)

# Close all windows
close_all_windows()
