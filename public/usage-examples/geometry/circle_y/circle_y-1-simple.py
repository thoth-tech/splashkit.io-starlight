from splashkit import *

open_window("Circle Y", 800, 600)
clear_screen(color_white())

# Set position for the circle
x_position = 400
# Give random  y_position value bewteen 200 - 400
y_position = rnd_range(200, 400)

# Create a circle A at the position (x_position, y_position)
A = circle_at(point_at(x_position, y_position), 200)

# Find the y position of the circle A
circleY = circle_y(A)

# Draw the circle
draw_circle(color_red(), x_position, circleY, 200)

# Draw a line to show the circle Y coordinate
draw_line(color_black(), 0, circleY, 800, circleY)
    
text = "Circle Y: " + str(circleY)
# Print result on the window
draw_text(text, color_black(), 0, 20, 100, 100)

# Draw 10 circles with radient 50 and the same circle y coordinate
for i in range(10):
    x = i * 60 + 100
    radiant = 50

    draw_circle(color_blue(), x, circleY, radiant)
    
refresh_screen()
delay(4000)
close_all_windows()
