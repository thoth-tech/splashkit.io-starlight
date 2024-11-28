from splashkit import *

open_window("Center Point", 800, 600)
clear_screen(color_white())

# Set position for the circle
x_position = 400
y_position = 300

# Create a circle at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Draw the Circle A
draw_circle(color_red(), x_position, y_position, 200)

# Access the center of the circle
center = A.center  
# Draw Point in the center of the circle
fill_circle(color_black(), center.x, center.y, 3)

# Print result on window
text = "Center Point At: (" + str(center.x) + ", " + str(center.y) + ")"
draw_text(text, color_black(), 0, 20, x_position - 20, y_position - 20)

refresh_screen()
delay(4000)
close_all_windows()