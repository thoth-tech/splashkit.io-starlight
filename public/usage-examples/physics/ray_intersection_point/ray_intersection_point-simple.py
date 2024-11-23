from splashkit import *

# Open the window
open_window("Ray Intersection", 300, 300)

# Define the ray
ray_origin = Point2D(150, 150)
ray_vector = vector_from_angle(45, 100)
ray_line = line_from(ray_origin, ray_vector)

# Define the walls
red_start = Point2D(150, 200)
red_end = Point2D(300, 200)
red_wall = line_from(red_start, red_end)

black_start = Point2D(150, 50)
black_end = Point2D(200, 50)
black_wall = line_from(black_start, black_end)

# Define collision points
collision_point_1 = Point2D(250, 250)
collision_point_2 = Point2D(250, 125)

# Visualize the scene
clear_screen(color_white())
fill_circle(color_brown(), circle_at(collision_point_1, 2))
fill_circle(color_brown(), circle_at(collision_point_2, 2))
draw_line(color_blue(), ray_line)
draw_line(color_red(), red_wall)
draw_line(color_black(), black_wall)

# Check for ray-wall intersections
if ray_intersection_point(ray_origin, ray_vector, red_wall, collision_point_1):
    write_line("Collision with red wall!")
if ray_intersection_point(ray_origin, ray_vector, black_wall, collision_point_2):
    write_line("Collision with black wall!")

refresh_screen()
delay(4000)
close_all_windows()
