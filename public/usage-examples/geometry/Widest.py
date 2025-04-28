from splashkit import *

def normalize_vector(v):
    mag = math.sqrt(v.x**2 + v.y**2)
    return vector_to(v.x / mag, v.y / mag) if mag != 0 else vector_to(0, 0)

def widest_points(c, direction, pt1, pt2):
    unit = normalize_vector(direction)
    offset = vector_multiply(unit, c.radius)
    pt1.x = c.center.x + offset.x
    pt1.y = c.center.y + offset.y
    pt2.x = c.center.x - offset.x
    pt2.y = c.center.y - offset.y

open_window("Widest Points Python", 800, 600)

circle_center = point_at(400, 300)
my_circle = circle_at(circle_center, 100)

direction = normalize_vector(vector_point_to_point(point_at(0, 0), point_at(1, 2)))
pt1 = point_at(0, 0)
pt2 = point_at(0, 0)
widest_points(my_circle, direction, pt1, pt2)

while not window_close_requested("Widest Points Python"):
    process_events()
    clear_screen(Color.White)

    draw_circle(Color.SkyBlue, my_circle)
    draw_line(Color.DarkGray, circle_center, point_at(circle_center.x + direction.x * 100, circle_center.y + direction.y * 100))
    fill_circle(Color.Red, pt1.x, pt1.y, 5)
    fill_circle(Color.Red, pt2.x, pt2.y, 5)

    draw_text(f"Vector: ({direction.x:.2f}, {direction.y:.2f})", Color.Black, 10, 30)
    draw_text(f"Point 1: ({pt1.x:.2f}, {pt1.y:.2f})", Color.Black, 10, 50)
    draw_text(f"Point 2: ({pt2.x:.2f}, {pt2.y:.2f})", Color.Black, 10, 70)

    refresh_screen(60)
