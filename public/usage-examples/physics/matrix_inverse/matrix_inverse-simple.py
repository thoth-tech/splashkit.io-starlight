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

# Calculate the inverse matrix
my_matrix_1_inverse = matrix_inverse(my_matrix_1)

# Print the original and inverse matrices
write_line(matrix_to_string(my_matrix_1))
write_line(matrix_to_string(my_matrix_1_inverse))
