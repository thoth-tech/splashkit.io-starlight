# Demonstrates ray_circle_intersect_distance by drawing a ray and a circle.
# Shows the distance from the ray origin to the intersection point on the circle.

from splashkit import *

open_window("Ray-Circle Intersection", 600, 400)

origin = point_at(300, 200)
direction = vector_to(1, 0)
r = ray_from_point_and_direction(origin, direction)
c = circle_at(400, 200, 50)

dist = ray_circle_intersect_distance(r, c)

clear_screen(Color.White)
draw_circle(Color.Red, c)
draw_line(Color.Blue, r.origin, point_at(r.origin.x + 600, r.origin.y))

if dist >= 0:
    hit = point_at(r.origin.x + direction.x * dist, r.origin.y + direction.y * dist)
    draw_circle(Color.Green, hit.x, hit.y, 5)

refresh_screen()
delay(3000)
