from splashkit import *

# This program demonstrates the use of the distant_point_on_circle_heading function.
# It draws a circle and a point, then calculates and shows the farthest point
# on the circle in the direction away from the fixed point.

open_window("Farthest Point", 400, 300)

c = Circle(center=point_at(200, 150), radius=50)
from_pt = point_at(100, 50)
heading = vector_to(from_pt.x - c.center.x, from_pt.y - c.center.y)

far_point = distant_point_on_circle_heading(c, heading)

while not window_close_requested("Farthest Point"):
    process_events()
    clear_screen(Color.White)

    draw_circle(Color.Black, c)
    draw_pixel(Color.Red, from_pt)
    draw_pixel(Color.Blue, far_point)

    refresh_screen(60)
