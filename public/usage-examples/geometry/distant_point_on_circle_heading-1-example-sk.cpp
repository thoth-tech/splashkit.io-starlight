#include "splashkit.h"

int main()
{
    open_window("Laser Passing Through Shield", 800, 600);

    // Declare variables
    point_2d player_position = point_at(0, 0);
    circle shield = circle_at(point_at(400, 300), 100);
    point_2d aim_point;
    vector_2d heading;
    float entry_distance;
    point_2d entry_point;
    point_2d exit_point = point_at(0, 0);

    while (!quit_requested())
    {
        process_events();

        // Calculate laser heading using mouse position
        aim_point = mouse_position();
        heading = unit_vector(vector_point_to_point(player_position, aim_point));

        // Calculate distance from player to shield and point of entry
        entry_distance = ray_circle_intersect_distance(player_position, heading, shield);
        entry_point = point_at(player_position.x + heading.x * entry_distance,
                               player_position.y + heading.y * entry_distance);

        // Draw the shield (circle) and laser (line)
        clear_screen(COLOR_WHITE);
        draw_circle(COLOR_BLUE, shield);
        draw_line(COLOR_RED, player_position, aim_point);

        if (entry_distance > 0)
        {
            // Find exit point of laser
            if (distant_point_on_circle_heading(player_position, shield, heading, exit_point))
            {
                // Draw entry and exit points and line between entry and exit
                fill_circle(COLOR_ORANGE, entry_point.x, entry_point.y, 5);
                fill_circle(COLOR_GREEN, exit_point.x, exit_point.y, 5);
                draw_line(COLOR_PURPLE, entry_point, exit_point);
            }
        }

        refresh_screen(60);
    }

    return 0;
}
