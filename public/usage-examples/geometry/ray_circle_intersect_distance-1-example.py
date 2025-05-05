from splashkit import *

# Opens a new window
open_window("Distance From Ray To Circle", 800, 600)

# Defines a laser beam from the left edge of the screen to the right
ray_origin = point_at(0, 300)
ray_end = point_at(800, 100)
ray_direction = unit_vector(vector_to_point(ray_end))

# Defines a circle at the center of the screen with radius 100
target_circle = circle_at(point_at(400, 300), 100)

while not quit_requested():
    clear_screen()

    # Draws the ray as a blue line
    draw_line_point_to_point(color_blue(), ray_origin, ray_end)

    # Draws the red target circle
    draw_circle_record(color_red(), target_circle)

    # Calculates intersection distance between ray and circle
    distance = ray_circle_intersect_distance(ray_origin, ray_direction, target_circle)

    # Displays the distance to the circle
    draw_text_no_font_no_size(f"Distance to circle: {distance}", color_black(), 100, 100)

    refresh_screen_with_target_fps(60)
