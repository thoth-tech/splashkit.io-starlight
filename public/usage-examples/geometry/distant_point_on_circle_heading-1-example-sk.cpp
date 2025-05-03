#include "splashkit.h"

int main()
{
    // Open a new window
    open_window("Ray Exit Point From A Circle", 800, 600);

    // Define a red laser beam starting from the top-left toward bottom-right
    point_2d ray_origin = point_at(0, 0);
    point_2d ray_end = point_at(800, 500);
    vector_2d ray_direction = unit_vector(vector_to(ray_end));

    // Create a circle centered in the window with radius 100
    circle target_circle = circle_at(point_at(400, 300), 100);

    point_2d exit_point = point_at(0, 0);

    while (!quit_requested())
    {
        clear_screen(COLOR_WHITE);

        // Draw the laser beam
        draw_line(COLOR_RED, ray_origin, ray_end);

        // Draw the circle
        draw_circle(COLOR_BLUE, target_circle);

        // Try to find the distant point on the circle along the laser beam
        if (distant_point_on_circle_heading(ray_origin, target_circle, ray_direction, exit_point))
        {
            // If a valid exit point is found, draw it
            fill_circle(COLOR_GREEN, exit_point.x, exit_point.y, 5);
        }

        refresh_screen(60);
    }

    return 0;
}
