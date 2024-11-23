from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector
my_vector_2 = Vector2D()
my_vector_2.x = -300
my_vector_2.y = 150

# Calculate the angle between the two vectors
vector_angle = angle_between(my_vector_1, my_vector_2)

# Output the vectors and the angle
write_line(vector_to_string(my_vector_1))
write_line(vector_to_string(my_vector_2))
write_line(str(vector_angle))
