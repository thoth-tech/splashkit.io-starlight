from splashkit import *

# Define the start and end points
start_point = Point2D(200, 100)
end_point = Point2D(-300, 150)

# Calculate the vector from start point to end point
my_vector_1 = vector_point_to_point(start_point, end_point)

# Output the vector
write_line(vector_to_string(my_vector_1))
