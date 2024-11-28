from splashkit import *
import random

open_window("Circle Y", 800, 600)
clear_screen(color_white())

# Set position for the circle
x_position = 400
# Give random  y_position value bewteen 200 - 400
y_position = random.randint(200, 400)

# Create a circle A at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Find the y position of the circle A
circleY = circle_y(A)

# Draw the circle
draw_circle(color_red(), x_position, circleY, 200)

text = "Circle Y: " + str(circleY)
# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)


refresh_screen()
delay(4000)
close_all_windows()
