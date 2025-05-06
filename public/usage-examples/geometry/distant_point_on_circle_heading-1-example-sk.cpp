#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Laser Passing Through Shield", 800, 600);

    // Fixed player position
    point_2d player_position = point_at(0, 0);

    // Shield represented by a circle
    circle shield = circle_at(point_at(400, 300), 100);

    // Points for entry and exit on the shield
    point_2d entry_point;
    point_2d exit_point;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the shield
        draw_circle(COLOR_BLUE, shield);

        // Get current mouse position
        point_2d aim_point = mouse_position();

        // Draw aiming laser
        draw_line(COLOR_RED, player_position, aim_point);

        // Calculate laser heading
        vector_2d heading = unit_vector(vector_point_to_point(player_position, aim_point));

        // Find entry point (first intersection)
        float entry_distance = ray_circle_intersect_distance(player_position, heading, shield);

        if (entry_distance > 0)
        {
            // Draw entry point
            entry_point = point_at(
                player_position.x + heading.x * entry_distance,
                player_position.y + heading.y * entry_distance
            );
            fill_circle(COLOR_ORANGE, entry_point.x, entry_point.y, 5);

            // Find exit point using distant_point_on_circle_heading
            if (distant_point_on_circle_heading(player_position, shield, heading, exit_point))
            {
                fill_circle(COLOR_GREEN, exit_point.x, exit_point.y, 5);

                // Draw line between entry and exit
                draw_line(COLOR_PURPLE, entry_point, exit_point);
            }
        }

        refresh_screen(60);
    }

    return 0;
}
