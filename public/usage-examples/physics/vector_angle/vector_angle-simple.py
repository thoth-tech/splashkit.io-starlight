from splashkit import *

# Define the vector
my_vector_1 = Vector2D(200, 100)

# Calculate the angle of the vector
my_vector_1_angle = vector_angle(my_vector_1)

# Output the vector and its angle
write_line(vector_to_string(my_vector_1))
write_line(my_vector_1_angle)
