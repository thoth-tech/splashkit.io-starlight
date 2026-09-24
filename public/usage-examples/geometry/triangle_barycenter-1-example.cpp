#include "splashkit.h"

int main()
{
    open_window("Triangle Barycenter", 800, 600);

    triangle tri = triangle_from(
        200, 450,
        400, 120,
        620, 450
    );

    point_2d barycenter = triangle_barycenter(tri);

    while (!quit_requested())
    {
        process_events();

        clear_screen(color_white());

        fill_triangle(color_light_blue(), tri);
        draw_triangle(color_black(), tri);

        fill_circle(color_red(), barycenter, 8);

        draw_text(
            "Triangle Barycenter",
            color_black(),
            20,
            20
        );

        draw_text(
            "The red point shows the barycenter of the triangle.",
            color_black(),
            20,
            50
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}