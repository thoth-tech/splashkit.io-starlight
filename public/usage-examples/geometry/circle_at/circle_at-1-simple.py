from splashkit import *

open_window("Circle At", 800, 600)
clear_screen(color_white())

# Set position for the circle
x_position = 400
y_position = 300

# Create a circle A at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Draw the circle
draw_circle(color_red(), x_position, y_position, 200)

text = "Circle At: (400,300), Radius: 200"
# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)

refresh_screen()
delay(4000)
close_all_windows()
