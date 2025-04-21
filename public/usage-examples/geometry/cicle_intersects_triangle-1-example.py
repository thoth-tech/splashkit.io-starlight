from splashkit import *

open_window("Circle-Triangle Intersect", 600, 600)

# A fixed triangle is placed as the target.
target = triangle_from(300, 100, 250, 300, 350, 300)

# A circle moves with arrow keys.
player_circle = circle_at(point_at(100, 100), 20)

while not window_close_requested("Circle-Triangle Intersect"):
    process_events()

    if key_down(KeyCode.UP_KEY):
        player_circle.center.y -= 2
    if key_down(KeyCode.DOWN_KEY):
        player_circle.center.y += 2
    if key_down(KeyCode.LEFT_KEY):
        player_circle.center.x -= 2
    if key_down(KeyCode.RIGHT_KEY):
        player_circle.center.x += 2

    clear_screen(Color.White)
    draw_triangle(Color.Black, target)

    # The circle turns green and text is displayed if it touches the triangle.
    intersects = circle_triangle_intersect(player_circle, target)
    circle_color = Color.Green if intersects else Color.Red

    draw_circle(circle_color, player_circle.center.x, player_circle.center.y, player_circle.radius)

    # Demonstrates the circle_triangle_intersect function.
    if intersects:
        draw_text("Circle is Intersecting the triangle", Color.Black, 170, 20)

    refresh_screen(60)