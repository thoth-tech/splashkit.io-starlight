from splashkit import *

# Open a new window
open_window("Ray Exit Point From A Circle", 800, 600)

# Define a laser beam starting from the top-left toward bottom-right
ray_origin = point_at(0, 0)
ray_end = point_at(800, 500)
ray_direction = unit_vector(vector_to_point(ray_end))

# Create a circle centered in the window with radius 100
target_circle = circle_at(point_at(400, 300), 100)

exit_point = point_at(0, 0)

while not quit_requested():
    clear_screen(color_white())

    # Draw the laser beam
    draw_line_point_to_point(color_red(), ray_origin, ray_end)

    # Draw the circle
    draw_circle_record(color_blue(), target_circle)

    # Try to find the exit point on the circle along the laser beam
    if distant_point_on_circle_heading(ray_origin, target_circle, ray_direction, exit_point):
        
        # If a valid exit point is found, draw it
        fill_circle(color_green(), exit_point.x, exit_point.y, 5)

    refresh_screen_with_target_fps(60)
