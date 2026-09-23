from splashkit import *

open_window("Rectangle Ray Intersection", 800, 600)

ray_start = point_at(100, 300)

ray_direction = vector_from_angle(0, 1)

rect = rectangle_from(450, 250, 150, 100)

hit_point = point_at(0, 0)
hit_distance = 0

# Check once because the ray and rectangle do not move during the loop
hit = rectangle_ray_intersection_with_hit_point_and_distance(
    ray_start,
    ray_direction,
    rect,
    hit_point,
    hit_distance
)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    draw_rectangle(color_blue(), rect)

    draw_line(
        color_black(),
        ray_start.x,
        ray_start.y,
        ray_start.x + ray_direction.x * 700,
        ray_start.y + ray_direction.y * 700
    )

    if hit:
        fill_circle(color_red(), hit_point.x, hit_point.y, 6)

    refresh_screen(60)

close_all_windows()