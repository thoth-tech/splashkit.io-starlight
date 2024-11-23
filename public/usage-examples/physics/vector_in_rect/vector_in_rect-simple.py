from splashkit import *

# Open a window for visualisation
open_window("Vector Visualisations", 300, 300)

# Define the rectangle
test_rectangle_1 = Rectangle(50, 50, 200, 200)

# Define two vectors using angles and magnitudes
my_vector_1 = vector_from_angle(45, 200)
my_vector_2 = vector_from_angle(10, 200)

# Clear the screen
clear_screen()

# Draw the rectangle and the vectors
fill_rectangle(color_black(), test_rectangle_1)
draw_line(color_red(), line_from(my_vector_1))
draw_line(color_blue(), line_from(my_vector_2))

# Check if vectors are inside the rectangle
if vector_in_rect(my_vector_1, test_rectangle_1):
    write_line("Red vector in rectangle!")
if vector_in_rect(my_vector_2, test_rectangle_1):
    write_line("Blue vector in rectangle!")

# Refresh the screen and wait
refresh_screen()
delay(4000)

# Close all windows
close_all_windows()
