from splashkit import *

# Open the window
open_window("Apply Matrix", 300, 300)

# Clear the screen
clear_screen(color_white())

# Define the quad points
test_rectangle_1 = Quad()
top_left = Point2D()
top_left.x = 140
top_left.y = 140

top_right = Point2D()
top_right.x = 160
top_right.y = 140

bottom_left = Point2D()
bottom_left.x = 140
bottom_left.y = 160

bottom_right = Point2D()
bottom_right.x = 160
bottom_right.y = 160

test_rectangle_1.points[0] = top_left
test_rectangle_1.points[1] = top_right
test_rectangle_1.points[2] = bottom_left
test_rectangle_1.points[3] = bottom_right

# Create and populate the matrix
my_matrix_1 = Matrix2D()
for i in range(3):
    for j in range(3):
        my_matrix_1.elements[i][j] = 0.5

# Draw the initial quad
draw_quad(color_black(), test_rectangle_1)
write_line("Quad points before matrix application:")
for point in test_rectangle_1.points:
    write_line(point_to_string(point))

# Apply the matrix to the quad
apply_matrix(my_matrix_1, test_rectangle_1)

# Draw the transformed quad
draw_quad(color_red(), test_rectangle_1)
write_line("Quad points after matrix application:")
for point in test_rectangle_1.points:
    write_line(point_to_string(point))

# Refresh the screen and wait
refresh_screen()
delay(4000)

# Close all windows
close_all_windows()
