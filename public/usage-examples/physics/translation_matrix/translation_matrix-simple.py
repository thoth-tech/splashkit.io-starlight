from splashkit import *

# Define the translation values
translation_x = 200
translation_y = 100

# Create a translation matrix using the translation values
my_matrix_1 = translation_matrix(translation_x, translation_y)

# Print the translation matrix to the console
write_line(matrix_to_string(my_matrix_1))
