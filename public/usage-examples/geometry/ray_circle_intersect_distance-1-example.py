from splashkit import *

open_window("Ray-Circle Intersection Distance", 800, 600)

# Declare variables
ray_origin = point_at(0, 0)
target_circle = circle_at(point_at(400, 300), 100)
mouse_pos = point_at(0, 0)
ray_heading = vector_to(0, 0)
distance_to_circle = 0.0

while not quit_requested():
    process_events()

    # Calculate ray heading from origin to mouse
    mouse_pos = mouse_position()
    ray_heading = unit_vector(vector_point_to_point(ray_origin, mouse_pos))

    # Find intersection distance between ray and circle
    distance_to_circle = ray_circle_intersect_distance(ray_origin, ray_heading, target_circle)

    # Draw scene
    clear_screen(color_white())
    draw_circle_record(color_blue(), target_circle)
    draw_line_point_to_point(color_red(), ray_origin, mouse_pos)

    if distance_to_circle > 0:
        hit_point = point_at(ray_origin.x + ray_heading.x * distance_to_circle,
                             ray_origin.y + ray_heading.y * distance_to_circle)
        fill_circle(color_green(), hit_point.x, hit_point.y, 5)

        # Display the distance
        draw_text_no_font_no_size("Distance to Circle: " + str(distance_to_circle), color_black(), 10, 10)
    else:
        # Display no intersection message
        draw_text_no_font_no_size("No Intersection", color_black(), 10, 10)

    refresh_screen_with_target_fps(60)
