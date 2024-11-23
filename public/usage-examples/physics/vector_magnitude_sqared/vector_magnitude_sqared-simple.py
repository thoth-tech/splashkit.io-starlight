from splashkit import *

# Define a vector
my_vector_1 = Vector2D(200, 100)

# Calculate the squared magnitude of the vector
my_vector_1_magnitude_squared = vector_magnitude_sqared(my_vector_1)

# Output the vector and its squared magnitude
write_line(vector_to_string(my_vector_1))
write_line(my_vector_1_magnitude_squared)
