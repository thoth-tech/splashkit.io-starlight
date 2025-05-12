#include "splashkit.h"

int main()
{
    open_window("Ray Collision with Circle", 800, 600);

    // Declare variables
    point_2d ray_origin = point_at(0, 0);
    circle target_circle = circle_at(point_at(400, 300), 100);
    point_2d mouse_pos;
    vector_2d ray_heading;
    float distance_to_circle;

    while (!quit_requested())
    {
        process_events();

        // Calculate ray heading from origin to mouse
        mouse_pos = mouse_position();
        ray_heading = unit_vector(vector_point_to_point(ray_origin, mouse_pos));

        // Find intersection distance between ray and circle
        distance_to_circle = ray_circle_intersect_distance(ray_origin, ray_heading, target_circle);

        // Draw scene
        clear_screen(COLOR_WHITE);
        draw_circle(COLOR_BLUE, target_circle);
        draw_line(COLOR_RED, ray_origin, mouse_pos);

        if (distance_to_circle > 0)
        {
            point_2d hit_point = point_at(ray_origin.x + ray_heading.x * distance_to_circle,
                                          ray_origin.y + ray_heading.y * distance_to_circle);
            fill_circle(COLOR_GREEN, hit_point.x, hit_point.y, 5);
        }

        refresh_screen(60);
    }

    return 0;
}
