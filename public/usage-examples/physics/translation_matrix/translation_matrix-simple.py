from splashkit import *

# Define the translation values
translation_x = 200
translation_y = 100

# Create a translation matrix using the translation values
translation_matrix = translation_matrix(translation_x, translation_y)

# Print the translation matrix to the console
write_line("Translation Matrix:")
write_line(matrix_to_string(translation_matrix))

# Define the original point
original_point = Point2D()
original_point.x = 50
original_point.y = 50
write_line("Original Point: " + point_to_string(original_point))

# Apply the translation to the point
translated_point = matrix_multiply_point(translation_matrix, original_point)
write_line("Translated Point: " + point_to_string(translated_point))
