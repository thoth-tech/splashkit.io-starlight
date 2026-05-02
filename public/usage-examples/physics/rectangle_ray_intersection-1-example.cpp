#include "splashkit.h"

int main()
{
    open_window("Rectangle Ray Intersection", 800, 600);

    // Define the starting point of the ray
    point_2d ray_start = point_at(100, 300);

    // Define the direction of the ray
    vector_2d ray_direction = vector_from_angle(0, 1);

    // Create a rectangle in the path of the ray
    rectangle rect = rectangle_from(450, 250, 150, 100);

    // Store the point and distance where the ray hits the rectangle
    point_2d hit_point;
    double hit_distance;

    // Check if the ray intersects with the rectangle
    bool hit = rectangle_ray_intersection(ray_start, ray_direction, rect, hit_point, hit_distance);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the rectangle
        draw_rectangle(COLOR_BLUE, rect);

        // Draw the ray as a long line
        draw_line(
            COLOR_BLACK,
            ray_start.x,
            ray_start.y,
            ray_start.x + ray_direction.x * 700,
            ray_start.y + ray_direction.y * 700
        );

        // If the ray hits the rectangle, draw the hit point
        if (hit)
        {
            fill_circle(COLOR_RED, hit_point.x, hit_point.y, 6);
        }

        refresh_screen(60);
    }

    return 0;
}