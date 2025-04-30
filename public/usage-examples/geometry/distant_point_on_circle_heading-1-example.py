from splashkit import *

clear_screen(Color.White)

center = Point2D(400, 300)
radius = 100
heading = 90
from_point = Point2D(100, 100)
far_point = distant_point_on_circle_heading(center, radius, from_point, heading)

draw_circle(Color.Blue, center, radius)
draw_pixel(Color.Red, far_point)

refresh_screen(60)
delay(5000)
