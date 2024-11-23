from splashkit import *

# Define the first vector
my_vector_1 = Vector2D()
my_vector_1.x = 200
my_vector_1.y = 100

# Define the second vector
my_vector_2 = Vector2D()
my_vector_2.x = -300
my_vector_2.y = 150

# Define the third vector
my_vector_3 = Vector2D()
my_vector_3.x = 200
my_vector_3.y = 100

# Check if vectors are not equal
check_1_2 = vectors_not_equal(my_vector_1, my_vector_2)
check_1_3 = vectors_not_equal(my_vector_1, my_vector_3)
check_2_3 = vectors_not_equal(my_vector_2, my_vector_3)

# Output the results
write_line(check_1_2)
write_line(check_1_3)
write_line(check_2_3)
