#include "splashkit.h"

int main()
{
    open_window("Triangle Quad Intersect", 800, 600);

    // Create a fixed quad
    quad target_quad = quad_from(
        450, 180,
        650, 180,
        450, 380,
        650, 380
    );

    while (!quit_requested())
    {
        process_events();

        // Get the current mouse position
        double mx = mouse_x();
        double my = mouse_y();

        // Create a triangle that follows the mouse
        triangle moving_triangle = triangle_from(
            mx, my - 60,
            mx - 60, my + 50,
            mx + 60, my + 50
        );

        // Check whether the triangle intersects the quad
        bool intersects = triangle_quad_intersect(
            moving_triangle,
            target_quad
        );

        clear_screen(COLOR_WHITE);

        // Draw the fixed quad
        fill_quad(COLOR_LIGHT_GRAY, target_quad);
        draw_quad(COLOR_BLACK, target_quad);

        // Draw the triangle and show the intersection result
        if (intersects)
        {
            fill_triangle(COLOR_RED, moving_triangle);
            draw_text(
                "Triangle intersects the quad!",
                COLOR_RED,
                20,
                20
            );
        }
        else
        {
            fill_triangle(COLOR_BLUE, moving_triangle);
            draw_text(
                "Move the triangle into the quad",
                COLOR_BLACK,
                20,
                20
            );
        }

        draw_triangle(COLOR_BLACK, moving_triangle);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}