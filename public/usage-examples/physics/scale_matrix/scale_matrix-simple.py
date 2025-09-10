from splashkit import *

# Define the uniform scaling factor
scaling_factor = 2.0

# Create a scaling matrix using the uniform scaling factor
scaling_matrix = scale_matrix(scaling_factor)

# Print the scaling matrix to the console
write_line("Scaling Matrix (Uniform Scaling by factor of 2):")
write_line(matrix_to_string(scaling_matrix))

# Define a point
original_point = Point2D()
original_point.x = 100
original_point.y = 50
write_line("Original Point:")
write_line(point_to_string(original_point))

# Apply the scaling matrix to the point
scaled_point = matrix_multiply_point(scaling_matrix, original_point)
write_line("Scaled Point (after scaling by factor of 2):")
write_line(point_to_string(scaled_point))
