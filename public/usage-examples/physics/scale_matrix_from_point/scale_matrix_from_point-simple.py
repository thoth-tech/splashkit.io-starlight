from splashkit import *

# Define the scale factors
matrix_scale = Point2D()
matrix_scale.x = 2.0  # Scale width by 2
matrix_scale.y = 1.0  # Keep height unchanged

# Create a scaling matrix using the scale factors
scaling_matrix = scale_matrix_from_point(matrix_scale)

# Print the scaling matrix
write_line("Scaling Matrix:")
write_line(matrix_to_string(scaling_matrix))

# Define a point to apply the scaling matrix
original_point = Point2D()
original_point.x = 100
original_point.y = 50
write_line(f"Original Point: {point_to_string(original_point)}")

# Apply the scaling matrix to the point
scaled_point = matrix_multiply_point(scaling_matrix, original_point)
write_line(f"Scaled Point (after applying scaling matrix): {point_to_string(scaled_point)}")
