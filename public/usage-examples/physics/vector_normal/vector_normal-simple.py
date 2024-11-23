from splashkit import *

# Define vectors
my_vector_1 = Vector2D(200, 100)
my_vector_2 = Vector2D(0, 0)

# Calculate normals
my_vector_1_normal = vector_normal(my_vector_1)
my_vector_2_normal = vector_normal(my_vector_2)

# Display results for the first vector
write_line("Original Vector: " + vector_to_string(my_vector_1))
write_line("Original Vector Magnitude: " + str(vector_magnitude(my_vector_1)))
write_line("Vector Normal: " + vector_to_string(my_vector_1_normal))
write_line("Vector Normal Magnitude: " + str(vector_magnitude(my_vector_1_normal)))

# Display results for the null vector
write_line("Null Vector: " + vector_to_string(my_vector_2))
write_line("Null Vector Magnitude: " + str(vector_magnitude(my_vector_2)))
write_line("Null Vector Normal: " + vector_to_string(my_vector_2_normal))
write_line("Null Vector Normal Magnitude: " + str(vector_magnitude(my_vector_2_normal)))
