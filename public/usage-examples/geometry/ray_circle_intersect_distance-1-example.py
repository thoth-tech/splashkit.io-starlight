from splashkit import *

# opens a new 800 * 600 window
open_window("Ray-Circle Intersect Distance", 800, 600)

# sets the starting point of the ray on the left side of the screen
ray_origin = point_at(100, 200)

# creates a direction vector pointing to the right and slightly downward
ray_direction = unit_vector(vector_to(point_at(700, 300)))

# defines a circle at the center of the screen with radius 100
circle_center = point_at(400, 300)
circle_radius = 100
circle_obj = make_circle(circle_center, circle_radius)

# runs until the user quits the program
while not quit_requested():
    # fills the screen with white
    clear_screen(Color.White)

    # calculates the ray's end point for drawing
    ray_end = point_offset_by(ray_origin, vector_multiply(ray_direction, 800))

    # draws the ray as a blue line
    draw_line(Color.Blue, ray_origin, ray_end)

    # draws the red target circle
    draw_circle(Color.Red, circle_center.x, circle_center.y, circle_radius)

    # calculates intersection distance between ray and circle
    distance = ray_circle_intersect_distance(ray_origin, ray_direction, circle_obj)

    # if the ray intersects, calculate and draw the impact point as a green dot
    if distance > 0:
        hit_point = point_offset_by(ray_origin, vector_multiply(ray_direction, distance))
        fill_circle(Color.Green, hit_point.x, hit_point.y, 5)

    # refreshes the screen at 60 FPS
    refresh_screen(60)
