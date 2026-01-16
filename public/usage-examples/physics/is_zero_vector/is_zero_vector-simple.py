from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector (zero vector)
my_vector_2 = Vector2D()
my_vector_2.x = 0
my_vector_2.y = 0

# Check if the vectors are zero vectors
check_zero_1 = is_zero_vector(my_vector_1)
check_zero_2 = is_zero_vector(my_vector_2)

# Output the results with descriptive messages
write_line("Checking if my_vector_1 is a zero vector:")
write_line("my_vector_1 is a zero vector." if check_zero_1 else "my_vector_1 is not a zero vector.")

write_line("Checking if my_vector_2 is a zero vector:")
write_line("my_vector_2 is a zero vector." if check_zero_2 else "my_vector_2 is not a zero vector.")
