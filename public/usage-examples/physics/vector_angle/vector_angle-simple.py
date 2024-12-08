from splashkit import *

# Define the vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Calculate the angle of the vector
my_vector_1_angle = vector_angle(my_vector_1)

# Output the vector and its angle
write_line("Vector 1: " + vector_to_string(my_vector_1))
write_line(f"Vector Angle: {my_vector_1_angle}")
