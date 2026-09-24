#include "splashkit.h"

int main()
{
    open_window("Moving Triangle Intersection", 800, 600);

    triangle fixed_triangle = triangle_from(
        point_at(250, 200),
        point_at(400, 150),
        point_at(350, 350)
    );

    while (!quit_requested())
    {
        process_events();

        point_2d mouse_point = mouse_position();

        triangle moving_triangle = triangle_from(
            point_at(mouse_point.x, mouse_point.y - 60),
            point_at(mouse_point.x - 60, mouse_point.y + 40),
            point_at(mouse_point.x + 60, mouse_point.y + 40)
        );

        clear_screen(color_white());

        draw_triangle(color_blue(), fixed_triangle);

        if (triangles_intersect(fixed_triangle, moving_triangle))
        {
            draw_triangle(color_red(), moving_triangle);
            draw_text(
                "The triangles intersect",
                color_red(),
                250,
                50
            );
        }
        else
        {
            draw_triangle(color_green(), moving_triangle);
            draw_text(
                "The triangles do not intersect",
                color_green(),
                225,
                50
            );
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
