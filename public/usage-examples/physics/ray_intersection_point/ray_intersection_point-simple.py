from splashkit import *

# Define the ray
ray_origin = Point2D()
ray_origin.x = 200
ray_origin.y = 200

ray_vector = Vector2D()
ray_vector = vector_from_angle(45, 150)

ray_line = Line()
ray_line = line_from_start_with_offset(ray_origin, ray_vector)

# Define the walls
red_start = Point2D()
red_start.x = 100
red_start.y = 300

red_end = Point2D()
red_end.x = 300
red_end.y = 300

red_wall = Line()
red_wall.start_point = red_start
red_wall.end_point = red_end

black_start = Point2D()
black_start.x = 100
black_start.y = 100

black_end = Point2D()
black_end.x = 300
black_end.y = 100

black_wall = Line()
black_wall.start_point = black_start
black_wall.end_point = black_end

# Open the window
open_window("Ray Intersection", 400, 400)

# Visualize the scene
clear_screen(color_white())
write_line("Drawing Blue Ray")
draw_line_record(color_blue(), ray_line)

write_line("Drawing Red and Black Walls")
draw_line_record(color_red(), red_wall)
draw_line_record(color_black(), black_wall)

# Check for ray-wall intersections
collision_point_1 = Point2D()
collision_point_2 = Point2D()

if ray_intersection_point(ray_origin, ray_vector, red_wall, collision_point_1):
    write_line("Collision with red wall at: " + point_to_string(collision_point_1))
    fill_circle_record(color_green(), circle_at(collision_point_1, 4))
else:
    write_line("No collision with red wall.")

if ray_intersection_point(ray_origin, ray_vector, black_wall, collision_point_2):
    write_line("Collision with black wall at: " + point_to_string(collision_point_2))
    fill_circle_record(color_green(), circle_at(collision_point_2, 4))
else:
    write_line("No collision with black wall.")

# Refresh the screen and wait
refresh_screen()
delay(5000)
close_all_windows()
