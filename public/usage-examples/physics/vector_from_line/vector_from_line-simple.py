from splashkit import *

# Open the window
open_window("Vector Visualisations", 300, 300)

# Define points for lines
origin = Point2D()
origin.x = 150
origin.y = 150

line_1_end = Point2D()
line_1_end.x = 173
line_1_end.y = 221

line_2_end = Point2D()
line_2_end.x = 90
line_2_end.y = 194

line_3_end = Point2D()
line_3_end.x = 90
line_3_end.y = 106

line_4_end = Point2D()
line_4_end.x = 173
line_4_end.y = 79

line_5_end = Point2D()
line_5_end.x = 225
line_5_end.y = 150

# Create lines
line_1 = line_from_point_to_point(origin, line_1_end)
line_2 = line_from_point_to_point(origin, line_2_end)
line_3 = line_from_point_to_point(origin, line_3_end)
line_4 = line_from_point_to_point(origin, line_4_end)
line_5 = line_from_point_to_point(origin, line_5_end)

# Convert lines to vectors
my_vector_1 = vector_from_line(line_1)
my_vector_2 = vector_from_line(line_2)
my_vector_3 = vector_from_line(line_3)
my_vector_4 = vector_from_line(line_4)
my_vector_5 = vector_from_line(line_5)

# Clear the screen
clear_screen(color_white())

# Output the vector details
write_line("Vector 1: " + vector_to_string(my_vector_1))
write_line("Vector 2: " + vector_to_string(my_vector_2))
write_line("Vector 3: " + vector_to_string(my_vector_3))
write_line("Vector 4: " + vector_to_string(my_vector_4))
write_line("Vector 5: " + vector_to_string(my_vector_5))

# Draw lines
draw_line_record(color_blue(), line_1)
draw_line_record(color_red(), line_2)
draw_line_record(color_black(), line_3)
draw_line_record(color_purple(), line_4)
draw_line_record(color_orange(), line_5)

# Refresh the screen
refresh_screen()

# Wait and close the window
delay(4000)
close_all_windows()
