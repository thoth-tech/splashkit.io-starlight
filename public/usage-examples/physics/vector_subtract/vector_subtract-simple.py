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
my_vector_3 = vector_subtract(my_vector_1, my_vector_2)

# Output the result of the subtraction
write_line(vector_to_string(my_vector_3))
