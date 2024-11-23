from splashkit import *

# Define the original vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Compute the unit vector
my_unit_vector_1 = unit_vector(my_vector_1)

# Output the original vector and its magnitude
write_line("Original Vector: " + vector_to_string(my_vector_1))
write_line("Original Vector Magnitude: " + str(vector_magnitude(my_vector_1)))

# Output the unit vector and its magnitude
write_line("Unit Vector: " + vector_to_string(my_unit_vector_1))
write_line("Unit Vector Magnitude: " + str(vector_magnitude(my_unit_vector_1)))
