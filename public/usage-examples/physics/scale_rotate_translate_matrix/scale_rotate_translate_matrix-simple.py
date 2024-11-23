from splashkit import *

# Define the scaling factors
matrix_scale = Point2D()
matrix_scale.x = 200
matrix_scale.y = 100

# Define the translation
matrix_translation = Point2D()
matrix_translation.x = 50
matrix_translation.y = 50

# Define the rotation angle
rotation = 90

# Create a matrix combining scaling, rotation, and translation
my_matrix_1 = scale_rotate_translate_matrix(matrix_scale, rotation, matrix_translation)

# Print the resulting matrix to the console
write_line(matrix_to_string(my_matrix_1))
