from splashkit import *

# Define the translation vector
matrix_translation = Vector2D()
matrix_translation.x = 200
matrix_translation.y = 100

# Create a translation matrix using the translation vector
my_matrix_1 = translation_matrix(matrix_translation)

# Print the translation matrix to the console
write_line(matrix_to_string(my_matrix_1))
