from splashkit import *

# Define the vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

vector_scale = 5

# Multiply the vector by a scalar value
write_line("Multiply Vector by: " + str(vector_scale))
my_vector_1_multiplied = vector_multiply(my_vector_1, vector_scale)

# Output the original and multiplied vectors
write_line("Original Vector: " + vector_to_string(my_vector_1))
write_line("Vector multiplied by scaling value: " + vector_to_string(my_vector_1_multiplied))
