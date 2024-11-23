from splashkit import *

# Define a point
my_point_1 = Point2D()
my_point_1.x = 200
my_point_1.y = 100

# Create a vector pointing to the point
my_vector_1 = vector_to_point(my_point_1)

# Output the vector
write_line("my_vector_1 values: " + vector_to_string(my_vector_1))
