from splashkit import *

# Define the scale factors
matrix_scale = Vector2D()
matrix_scale.x = 2.0  # Scale width by 2
matrix_scale.y = 1.0  # Keep height unchanged

# Create a scaling matrix using the scale factors
scaling_matrix = scale_matrix_from_vector(matrix_scale)

# Print the scaling matrix
write_line("Scaling Matrix:")
write_line(matrix_to_string(scaling_matrix))

# Define a vector to demonstrate the scaling
original_vector = Vector2D()
original_vector.x = 100
original_vector.y = 50
write_line("Original Vector: " + vector_to_string(original_vector))

# Apply the scaling matrix to the vector
scaled_vector = matrix_multiply_vector(scaling_matrix, original_vector)
write_line("Scaled Vector (after applying scaling matrix): " + vector_to_string(scaled_vector))
