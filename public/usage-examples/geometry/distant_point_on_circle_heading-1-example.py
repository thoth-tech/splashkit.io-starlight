from splashkit import *

open_window("Laser Passing Through Shield", 800, 600)

# Declare variables
player_position = point_at(0, 0)
shield = circle_at(point_at(400, 300), 100)
aim_point = point_at(0, 0)
heading = vector_to(0, 0)
entry_distance = 0.0
entry_point = point_at(0, 0)
exit_point = point_at(0, 0)

while not quit_requested():
    process_events()

    # Calculate laser heading using mouse position
    aim_point = mouse_position()
    heading = unit_vector(vector_point_to_point(player_position, aim_point))

    # Calculate distance from player to shield and point of entry
    entry_distance = ray_circle_intersect_distance(player_position, heading, shield)
    entry_point = point_at(player_position.x + heading.x * entry_distance,
                           player_position.y + heading.y * entry_distance)

    # Draw the shield (circle) and laser (line)
    clear_screen(color_white())
    draw_circle_record(color_blue(), shield)
    draw_line_point_to_point(color_red(), player_position, aim_point)

    if entry_distance > 0:
        # Find exit point of laser
        if distant_point_on_circle_heading(player_position, shield, heading, exit_point):
            # Draw entry and exit points and line between entry and exit
            fill_circle(color_orange(), entry_point.x, entry_point.y, 5)
            fill_circle(color_green(), exit_point.x, exit_point.y, 5)
            draw_line_point_to_point(color_purple(), entry_point, exit_point)

    refresh_screen_with_target_fps(60)
