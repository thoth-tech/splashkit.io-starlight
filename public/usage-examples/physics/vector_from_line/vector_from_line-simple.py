from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define points for lines
origin = Point2D(150, 150)
line_1_end = Point2D(173, 221)
line_2_end = Point2D(90, 194)
line_3_end = Point2D(90, 106)
line_4_end = Point2D(173, 79)
line_5_end = Point2D(225, 150)

# Create lines
line_1 = line_from(origin, line_1_end)
line_2 = line_from(origin, line_2_end)
line_3 = line_from(origin, line_3_end)
line_4 = line_from(origin, line_4_end)
line_5 = line_from(origin, line_5_end)

# Convert lines to vectors
my_vector_1 = vector_from_line(line_1)
my_vector_2 = vector_from_line(line_2)
my_vector_3 = vector_from_line(line_3)
my_vector_4 = vector_from_line(line_4)
my_vector_5 = vector_from_line(line_5)

# Clear the screen
clear_screen()

# Output the vector details
write_line("Vector 1: " + vector_to_string(my_vector_1))
write_line("Vector 2: " + vector_to_string(my_vector_2))
write_line("Vector 3: " + vector_to_string(my_vector_3))
write_line("Vector 4: " + vector_to_string(my_vector_4))
write_line("Vector 5: " + vector_to_string(my_vector_5))

# Draw lines
draw_line(color_blue(), line_1)
draw_line(color_red(), line_2)
draw_line(color_black(), line_3)
draw_line(color_purple(), line_4)
draw_line(color_orange(), line_5)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
