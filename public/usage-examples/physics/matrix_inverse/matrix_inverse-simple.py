from splashkit import *

# Define a transformation matrix (scaling)
scaling_matrix = scale_matrix(2.0)

# Print the scaling matrix
write_line("Scaling Matrix:")
write_line(matrix_to_string(scaling_matrix))

# Calculate the inverse of the scaling matrix
inverse_matrix = matrix_inverse(scaling_matrix)

# Print the inverse matrix
write_line("Inverse Matrix:")
write_line(matrix_to_string(inverse_matrix))

# Define a point
original_point = Point2D()
original_point.x = 100
original_point.y = 100
write_line("Original Point: " + point_to_string(original_point))

# Transform the point
transformed_point = matrix_multiply_point(scaling_matrix, original_point)
write_line("Transformed Point: " + point_to_string(transformed_point))

# Apply the inverse transformation to recover the original point
recovered_point = matrix_multiply_point(inverse_matrix, transformed_point)
write_line("Recovered Point: " + point_to_string(recovered_point))
