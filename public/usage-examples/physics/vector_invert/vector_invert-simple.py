from splashkit import *

# Define a vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Invert the vector
my_vector_1_inverted = vector_invert(my_vector_1)

# Output the original and inverted vectors
write_line(vector_to_string(my_vector_1))
write_line(vector_to_string(my_vector_1_inverted))
