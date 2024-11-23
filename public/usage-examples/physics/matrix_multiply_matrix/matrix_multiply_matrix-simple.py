from splashkit import *

# Define and populate the matrix
my_matrix_1 = Matrix2D()
my_matrix_1.elements[0][0] = 1
my_matrix_1.elements[0][1] = 2
my_matrix_1.elements[0][2] = 3

my_matrix_1.elements[1][0] = 0
my_matrix_1.elements[1][1] = 1
my_matrix_1.elements[1][2] = 4

my_matrix_1.elements[2][0] = 5
my_matrix_1.elements[2][1] = 6
my_matrix_1.elements[2][2] = 0

# Define the point
my_point_1 = Point2D()
my_point_1.x = 200
my_point_1.y = 100

# Multiply the matrix by the point
result_point = matrix_multiply(my_matrix_1, my_point_1)

# Print the matrix and points
write_line(matrix_to_string(my_matrix_1))
write_line(point_to_string(my_point_1))
write_line(point_to_string(result_point))
