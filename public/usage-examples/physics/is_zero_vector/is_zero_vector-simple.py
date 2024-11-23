from splashkit import *

# Define the first vector
my_vector_1 = Vector2D(200, 100)

# Define the second vector (zero vector)
my_vector_2 = Vector2D(0, 0)

# Check if the vectors are zero vectors
check_zero_1 = is_zero_vector(my_vector_1)
check_zero_2 = is_zero_vector(my_vector_2)

# Output the results
write_line(str(check_zero_1))
write_line(str(check_zero_2))
