from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector
my_vector_2 = Vector2D()
my_vector_2.x = -300
my_vector_2.y = 150

# Subtract the vectors
result_vector = vector_subtract(my_vector_1, my_vector_2)

# Output the original vectors and the result
write_line("First Vector: " + vector_to_string(my_vector_1))
write_line("Second Vector: " + vector_to_string(my_vector_2))
write_line("Result of Subtraction (Vector 1 - Vector 2): " + vector_to_string(result_vector))
