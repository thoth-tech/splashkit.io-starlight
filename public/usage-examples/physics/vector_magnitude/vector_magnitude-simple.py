from splashkit import *

# Define the vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Calculate the magnitude of the vector
my_vector_1_magnitude = vector_magnitude(my_vector_1)

# Output the vector and its magnitude
write_line(vector_to_string(my_vector_1))
write_line(f"Vector Magnitude: {my_vector_1_magnitude}")
