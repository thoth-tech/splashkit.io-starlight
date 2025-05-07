#include "splashkit.h"

int main()
{
    // Open a new window
    open_window("Laser Collision with Circle", 800, 600);

    // Initialize the player position
    point_2d player_pos = point_at(0, 0);

    // Variables to store the latest shot data
    point_2d last_target = player_pos;
    vector_2d last_direction = vector_to(0, 0);
    float last_hit_distance = -1;

    // Define the target circle
    circle target = circle_at(point_at(400, 300), 100);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the target circle
        draw_circle(COLOR_BLUE, target);

        // Fire a laser when the mouse is clicked
        if (mouse_clicked(LEFT_BUTTON))
        {
            // Update the target position based on the mouse position
            last_target = mouse_position();
            last_direction = unit_vector(vector_point_to_point(player_pos, last_target));

            // Check for intersection and calculate hit distance
            last_hit_distance = ray_circle_intersect_distance(player_pos, last_direction, target);
        }

        // If a shot has been made, draw the laser and hit point
        if (last_hit_distance >= 0)
        {
            // Draw the laser beam
            draw_line(COLOR_RED, player_pos, last_target);

            // Draw the impact point
            if (last_hit_distance > 0)
            {
                fill_circle(COLOR_GREEN, player_pos.x + last_direction.x * last_hit_distance, player_pos.y + last_direction.y * last_hit_distance, 5);
            }
        }

        refresh_screen(60);
    }

    return 0;
}
