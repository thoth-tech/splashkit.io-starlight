from splashkit import *

# Define the vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Calculate the squared magnitude of the vector
my_vector_1_magnitude_squared = vector_magnitude_sqared(my_vector_1)

# Output the vector and its squared magnitude
write_line(vector_to_string(my_vector_1))
write_line(f"Vector Magnitude Squared: {my_vector_1_magnitude_squared}")
