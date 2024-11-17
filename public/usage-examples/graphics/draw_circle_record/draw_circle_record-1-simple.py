from splashkit import *

open_window("Draw Circles", 800, 600)

clear_screen(color_white())

# Define the center point of circles
center = point_at(400, 300)

# Create 4 Circles with different radii
circle1 = circle_at(center, 50)
circle2 = circle_at(center, 100)
circle3 = circle_at(center, 150)
circle4 = circle_at(center, 200)

# Draw the circles with different colors
draw_circle_record(color_red(), circle1)
draw_circle_record(color_blue(), circle2)
draw_circle_record(color_orange(), circle3)
draw_circle_record(color_green(), circle4)

refresh_screen()

delay(4000)

close_all_windows()
