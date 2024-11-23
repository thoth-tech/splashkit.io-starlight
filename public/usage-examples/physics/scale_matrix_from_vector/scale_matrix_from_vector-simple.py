from splashkit import *

# Define the scale factors
matrix_scale = Point2D()
matrix_scale.x = 200
matrix_scale.y = 100

# Create a scaling matrix using the scale factors
my_matrix_1 = scale_matrix(matrix_scale)

# Print the scaling matrix to the console
write_line(matrix_to_string(my_matrix_1))
