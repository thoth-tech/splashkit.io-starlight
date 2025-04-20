from splashkit import *
import math

def tangent_points(from_pt, c):
    v = vector_point_to_point(c.center, from_pt)
    d = math.sqrt(v.x**2 + v.y**2)
    if d < c.radius:
        return False, None, None
    r = c.radius
    angle_to_center = math.atan2(v.y, v.x)
    angle_offset = math.acos(r / d)
    angle1 = angle_to_center + angle_offset
    angle2 = angle_to_center - angle_offset
    p1 = point_at(c.center.x + r * math.cos(angle1), c.center.y + r * math.sin(angle1))
    p2 = point_at(c.center.x + r * math.cos(angle2), c.center.y + r * math.sin(angle2))
    return True, p1, p2

open_window("Dynamic Tangents", 800, 600)
c = circle_at(point_at(400, 300), 100)

while not window_close_requested("Dynamic Tangents"):
    process_events()
    from_pt = point_at(mouse_x(), mouse_y())
    valid, p1, p2 = tangent_points(from_pt, c)

    clear_screen(Color.White)
    draw_circle(Color.Black, c)
    fill_circle(Color.Red, from_pt.x, from_pt.y, 5)

    if valid:
        fill_circle(Color.Blue, p1.x, p1.y, 5)
        fill_circle(Color.Blue, p2.x, p2.y, 5)
        draw_line(Color.Green, from_pt, p1)
        draw_line(Color.Green, from_pt, p2)

    draw_text(f"External Point: ({int(from_pt.x)}, {int(from_pt.y)})", Color.Black, 10, 10)
    refresh_screen(60)
