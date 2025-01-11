from splashkit import *

# Define a vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Limit the vector magnitude to 10
my_vector_1_limited = vector_limit(my_vector_1, 10)

# Output the original and limited vectors
write_line(vector_to_string(my_vector_1))
write_line(vector_to_string(my_vector_1_limited))
