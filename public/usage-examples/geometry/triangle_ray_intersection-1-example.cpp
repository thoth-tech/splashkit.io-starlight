#include "splashkit.h"

int main()
{
    open_window("Triangle Ray Intersection", 800, 600);

    point_2d ray_origin = point_at(120, 300);

    triangle tri = triangle_from(
        point_at(500, 180),
        point_at(650, 420),
        point_at(420, 420)
    );

    while (!quit_requested())
    {
        process_events();

        point_2d mouse = mouse_position();

        vector_2d heading = vector_to(
            mouse.x - ray_origin.x,
            mouse.y - ray_origin.y
        );

        bool intersects = triangle_ray_intersection(
            ray_origin,
            heading,
            tri
        );

        clear_screen(COLOR_WHITE);

        if (intersects)
        {
            fill_triangle(COLOR_GREEN, tri);
            draw_text(
                "Ray intersects the triangle",
                COLOR_DARK_GREEN,
                20,
                20
            );
        }
        else
        {
            fill_triangle(COLOR_RED, tri);
            draw_text(
                "Ray does not intersect the triangle",
                COLOR_DARK_RED,
                20,
                20
            );
        }

        draw_triangle(COLOR_BLACK, tri);

        draw_circle(
            COLOR_BLUE,
            ray_origin.x,
            ray_origin.y,
            6
        );

        double ray_length = 1000;

        point_2d ray_end = point_at(
            ray_origin.x + heading.x * ray_length,
            ray_origin.y + heading.y * ray_length
        );

        draw_line(
            COLOR_BLUE,
            ray_origin.x,
            ray_origin.y,
            ray_end.x,
            ray_end.y
        );

        draw_text(
            "Move the mouse to change the ray direction",
            COLOR_BLACK,
            20,
            550
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}