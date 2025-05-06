from splashkit import *

# Open a window
open_window("Laser Passing Through Shield", 800, 600)

# Fixed player position
player_position = point_at(0, 0)

# Shield represented by a circle
shield = circle_at(point_at(400, 300), 100)

# Points for entry and exit on the shield
entry_point = point_at(0, 0)
exit_point = point_at(0, 0)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Draw the shield
    draw_circle_record(color_blue(), shield)

    # Get current mouse position
    aim_point = mouse_position()

    # Draw aiming laser
    draw_line_point_to_point(color_red(), player_position, aim_point)

    # Calculate laser heading
    heading = unit_vector(vector_point_to_point(player_position, aim_point))

    # Find entry point (first intersection)
    entry_distance = ray_circle_intersect_distance(player_position, heading, shield)

    if entry_distance > 0:
        # Draw entry point
        entry_point = point_at(
            player_position.x + heading.x * entry_distance,
            player_position.y + heading.y * entry_distance
        )
        fill_circle(color_orange(), entry_point.x, entry_point.y, 5)

        # Find exit point using distant_point_on_circle_heading
        if distant_point_on_circle_heading(player_position, shield, heading, exit_point):
            fill_circle(color_green(), exit_point.x, exit_point.y, 5)

            # Draw line between entry and exit
            draw_line_point_to_point(color_purple(), entry_point, exit_point)

    refresh_screen_with_target_fps(60)
