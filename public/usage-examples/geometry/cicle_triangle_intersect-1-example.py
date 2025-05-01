from splashkit import *

window = open_window("Circle-Triangle Intersect", 600, 600)

# A fixed triangle is placed as the target.
p1 = point_at(300, 100)
p2 = point_at(250, 300)
p3 = point_at(350, 300)
target = triangle_from(p1, p2, p3)


# A circle moves with arrow keys.
player_circle = circle_at(point_at(100, 100), 20)

while not window_close_requested(window):
    process_events()

    if key_down(KeyCode.up_key):
        player_circle.center.y -= 0.5
    if key_down(KeyCode.down_key):
        player_circle.center.y += 0.5
    if key_down(KeyCode.left_key):
        player_circle.center.x -= 0.5
    if key_down(KeyCode.right_key):
        player_circle.center.x += 0.5

    clear_screen(color_white())
    draw_triangle(color_black(), p1.x, p1.y, p2.x, p2.y, p3.x, p3.y)


    # The circle turns green and text is displayed if it touches the triangle.
    intersects = circle_triangle_intersect(player_circle, target)
    circle_color = color_green() if intersects else color_red()

    draw_circle(circle_color, player_circle.center.x, player_circle.center.y, player_circle.radius)

    # Demonstrates the circle_triangle_intersect function.
    if intersects:
       draw_text("Circle is Intersecting the triangle", color_black(),"arial", 20, 170, 20)

    refresh_screen()
