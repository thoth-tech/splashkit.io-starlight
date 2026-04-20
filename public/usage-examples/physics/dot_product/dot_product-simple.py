from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector
my_vector_2 = Vector2D()
my_vector_2.x = -300
my_vector_2.y = 150

# Calculate the dot product
vector_dot_product = dot_product(my_vector_1, my_vector_2)

# Output vector details and the dot product
write_line(vector_to_string(my_vector_1))
write_line(vector_to_string(my_vector_2))
write_line(f"Dot Product of Vectors: {vector_dot_product}")
