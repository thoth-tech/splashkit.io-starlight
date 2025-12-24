from splashkit import *

# Define the translation values
translation_x = 200
translation_y = 100

# Create a translation matrix using the translation values
my_matrix_1 = my_matrix_1(translation_x, translation_y)

# Print the translation matrix to the console
write_line("Translation Matrix:")
write_line(matrix_to_string(my_matrix_1))

# Define the original point
original_point = Point2D()
original_point.x = 50
original_point.y = 50
write_line("Original Point: " + point_to_string(original_point))

# Apply the translation to the point
translated_point = matrix_multiply_point(my_matrix_1, original_point)
write_line("Translated Point: " + point_to_string(translated_point))
