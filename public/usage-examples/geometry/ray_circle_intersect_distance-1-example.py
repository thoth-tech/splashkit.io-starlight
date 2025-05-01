from splashkit import *

# opens a new 800 * 600 window
open_window("Distance From Ray To Circle", 800, 600)

# sets the starting point of the ray on the left side of the screen
ray_origin = point_at(0, 300)

# sets the ending point of the ray on the right side of the screen
ray_end = point_at(800, 100)

# creates a direction vector pointing toward the right and slightly up
ray_direction = unit_vector(vector_to_point(ray_end))

# defines a circle at the center of the screen with radius 100
circle_center = point_at(400, 300)
circle_radius = 100
circle_obj = circle_at(circle_center, circle_radius)

# runs until the user quits the program
while not quit_requested():
    # fills the screen with white
    clear_screen(color_white())

    # draws the ray as a blue line
    draw_line_point_to_point(color_blue(), ray_origin, ray_end)

    # draws the red target circle
    draw_circle_record(color_red(), circle_obj)

    # calculates intersection distance between ray and circle
    distance = ray_circle_intersect_distance(ray_origin, ray_direction, circle_obj)

    # displays the distance to the circle
    draw_text_no_font_no_size(f"Distance to circle: {distance}", color_black(), 100, 100)

    refresh_screen()
