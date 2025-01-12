from splashkit import *

open_window("Circle X", 800, 600)
clear_screen(color_white())

# Set position for the circle
# Give random  x_position value bewteen 200 - 600
x_position = rnd_range(200, 600)
y_position = 300

# Create A circle name "A" at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Find the x position of the circle A
circleX = circle_x(A)

# Draw the circle
draw_circle(color_red(), circleX, y_position, 200)

text = "Circle X: " + str(circleX)

# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)

refresh_screen()
delay(4000)
close_all_windows()
