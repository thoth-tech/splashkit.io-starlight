#include "splashkit.h"

int main()
{
    open_window("Rectangle Ray Intersection", 800, 600);

    point_2d ray_start = point_at(100, 300);

    vector_2d ray_direction = vector_from_angle(0, 1);

    rectangle rect = rectangle_from(450, 250, 150, 100);

    point_2d hit_point;
    double hit_distance;

    // Check once because the ray and rectangle do not move during the loop
    bool hit = rectangle_ray_intersection(ray_start, ray_direction, rect, hit_point, hit_distance);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_rectangle(COLOR_BLUE, rect);

        draw_line(
            COLOR_BLACK,
            ray_start.x,
            ray_start.y,
            ray_start.x + ray_direction.x * 700,
            ray_start.y + ray_direction.y * 700
        );

        if (hit)
        {
            fill_circle(COLOR_RED, hit_point.x, hit_point.y, 6);
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}