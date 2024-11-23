from splashkit import *

# Define and populate the matrix
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

# Print the matrix
write_line("Matrix:")
write_line(matrix_to_string(my_matrix_1))

# Define the vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Print the vector
write_line("Original Vector:")
write_line(vector_to_string(my_vector_1))

# Multiply the matrix by the vector
result_vector = matrix_multiply_vector(my_matrix_1, my_vector_1)

# Print the resulting vector
write_line("Transformed Vector:")
write_line(vector_to_string(result_vector))
