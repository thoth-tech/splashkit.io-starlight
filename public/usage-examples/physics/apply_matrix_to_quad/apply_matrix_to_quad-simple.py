from splashkit import *

# Open the window
open_window("Apply Matrix", 400, 400)

# Clear the screen
clear_screen(color_white())

# Define the quad points
test_rectangle_1 = Quad()
top_left = Point2D()
top_left.x, top_left.y = 150, 150
top_right = Point2D()
top_right.x, top_right.y = 250, 150
bottom_left = Point2D()
bottom_left.x, bottom_left.y = 150, 250
bottom_right = Point2D()
bottom_right.x, bottom_right.y = 250, 250

test_rectangle_1.points[0] = top_left
test_rectangle_1.points[1] = top_right
test_rectangle_1.points[2] = bottom_left
test_rectangle_1.points[3] = bottom_right

# Define the transformation matrix (scaling + translation)
scaling_matrix = scale_matrix(0.5)
translation_matrix = translation_matrix(50, 50)
combined_matrix = matrix_multiply_matrix(scaling_matrix, translation_matrix)

# Draw the initial quad
fill_quad(color_black(), test_rectangle_1)
write_line("Quad points before matrix application:")
for i in range(4):
    write_line(point_to_string(test_rectangle_1.points[i]))

# Apply the matrix to the quad
apply_matrix_to_quad(combined_matrix, test_rectangle_1)

# Draw the transformed quad
fill_quad(color_red(), test_rectangle_1)
write_line("Quad points after matrix application:")
for i in range(4):
    write_line(point_to_string(test_rectangle_1.points[i]))

# Refresh the screen and wait
refresh_screen()
delay(4000)

# Close all windows
close_all_windows()
