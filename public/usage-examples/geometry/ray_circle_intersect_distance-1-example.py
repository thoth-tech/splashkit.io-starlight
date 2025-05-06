from splashkit import *

# Open a new window
open_window("Laser Collision with Circle", 800, 600)

# Initialize the player position
player_pos = point_at(0, 0)

# Variables to store the latest shot data
last_target = player_pos
last_direction = vector_to(0, 0)
last_hit_distance = -1

# Define the target circle
target = circle_at(point_at(400, 300), 100)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Draw the target circle
    draw_circle_record(color_blue(), target)

    # Fire a laser when the mouse is clicked
    if mouse_clicked(MouseButton.left_button):
        # Update the target position based on the mouse position
        last_target = mouse_position()
        last_direction = unit_vector(vector_point_to_point(player_pos, last_target))

        # Check for intersection and calculate hit distance
        last_hit_distance = ray_circle_intersect_distance(player_pos, last_direction, target)

    # If a shot has been made, draw the laser and hit point
    if last_hit_distance >= 0:
        # Draw the laser beam
        draw_line_point_to_point(color_red(), player_pos, last_target)

        # Draw the impact point
        if last_hit_distance > 0:
            fill_circle(color_green(), player_pos.x + last_direction.x * last_hit_distance, player_pos.y + last_direction.y * last_hit_distance, 5)

    refresh_screen_with_target_fps(60)
