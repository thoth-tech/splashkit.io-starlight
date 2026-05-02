from splashkit import *

open_window("Rectangle Ray Intersection", 800, 600)

# Define the starting point of the ray
ray_start = point_at(100, 300)

# Define the direction of the ray
ray_direction = vector_from_angle(0, 1)

# Create a rectangle in the path of the ray
rect = rectangle_from(450, 250, 150, 100)

# Store the point and distance where the ray hits the rectangle
hit_point = point_at(0, 0)
hit_distance = 0

# Check if the ray intersects with the rectangle
hit = rectangle_ray_intersection_with_hit_point_and_distance(
    ray_start,
    ray_direction,
    rect,
    hit_point,
    hit_distance
)

while not quit_requested():
    process_events()
    clear_screen(COLOR_WHITE)

    # Draw the rectangle
    draw_rectangle(COLOR_BLUE, rect)

    # Draw the ray as a long line
    draw_line(
        COLOR_BLACK,
        ray_start.x,
        ray_start.y,
        ray_start.x + ray_direction.x * 700,
        ray_start.y + ray_direction.y * 700
    )

    # If the ray hits the rectangle, draw the hit point
    if hit:
        fill_circle(COLOR_RED, hit_point.x, hit_point.y, 6)

    refresh_screen(60)