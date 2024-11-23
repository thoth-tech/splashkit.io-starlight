from splashkit import *

# Define and populate the first matrix
my_matrix_1 = Matrix2D()
my_matrix_1.elements[0] = 1
my_matrix_1.elements[1] = 2
my_matrix_1.elements[2] = 3
my_matrix_1.elements[3] = 0
my_matrix_1.elements[4] = 1
my_matrix_1.elements[5] = 4
my_matrix_1.elements[6] = 5
my_matrix_1.elements[7] = 6
my_matrix_1.elements[8] = 0

# Define and populate the second matrix
my_matrix_2 = Matrix2D()
my_matrix_2.elements[0] = 7
my_matrix_2.elements[1] = 8
my_matrix_2.elements[2] = 9
my_matrix_2.elements[3] = 1
my_matrix_2.elements[4] = 0
my_matrix_2.elements[5] = 2
my_matrix_2.elements[6] = 3
my_matrix_2.elements[7] = 4
my_matrix_2.elements[8] = 5

# Multiply the two matrices
result_matrix = matrix_multiply_matrix(my_matrix_1, my_matrix_2)

# Print the matrices and result
write_line("Matrix 1:")
write_line(matrix_to_string(my_matrix_1))

write_line("Matrix 2:")
write_line(matrix_to_string(my_matrix_2))

write_line("Resulting Matrix (Matrix 1 x Matrix 2):")
write_line(matrix_to_string(result_matrix))
