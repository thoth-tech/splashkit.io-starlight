from splashkit import *

# Create a rotation matrix for 45 degrees
rotation_matrix_45 = rotation_matrix(45)

# Print the rotation matrix to the console
write_line("Rotation Matrix (45 degrees):")
write_line(matrix_to_string(rotation_matrix_45))

# Define a point
original_point = Point2D()
original_point.x = 1  # A point on the x-axis
original_point.y = 0
write_line("Original Point:")
write_line(point_to_string(original_point))

# Apply the rotation matrix to the point
rotated_point = matrix_multiply_point(rotation_matrix_45, original_point)
write_line("Rotated Point (after 45-degree rotation):")
write_line(point_to_string(rotated_point))
