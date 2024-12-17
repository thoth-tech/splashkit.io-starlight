from splashkit import *

# Define a vector
my_vector = Vector2D()
my_vector.x = 200
my_vector.y = 100

# Output the details of the vector
write_line("Vector Details:")
write_line("X: " + str(my_vector.x))
write_line("Y: " + str(my_vector.y))
write_line("Vector as String: " + vector_to_string(my_vector))
