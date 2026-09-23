#include "splashkit.h"

int main()
{
    open_window("Triangle Rectangle Intersect Example", 800, 600);

    // Fixed rectangle used for intersection testing
    rectangle target_rect = rectangle_from(300, 220, 200, 160);

    while (!quit_requested())
    {
        process_events();

        // Position the triangle around the current mouse location
        double mouse_x_pos = mouse_x();
        double mouse_y_pos = mouse_y();

        triangle moving_triangle = triangle_from(
            mouse_x_pos,
            mouse_y_pos - 60,
            mouse_x_pos - 60,
            mouse_y_pos + 50,
            mouse_x_pos + 60,
            mouse_y_pos + 50
        );

        // Check whether the triangle intersects the rectangle
        bool intersects = triangle_rectangle_intersect(
            moving_triangle,
            target_rect
        );

        clear_screen(COLOR_WHITE);

        // Draw the fixed target rectangle
        fill_rectangle(
            COLOR_LIGHT_GRAY,
            target_rect
        );

        draw_rectangle(
            COLOR_BLACK,
            target_rect
        );

        // Change the triangle colour when an intersection occurs
        if (intersects)
        {
            fill_triangle(COLOR_RED, moving_triangle);
        }
        else
        {
            fill_triangle(COLOR_BLUE, moving_triangle);
        }

        draw_triangle(COLOR_BLACK, moving_triangle);

        draw_text(
            "Move the triangle with your mouse",
            COLOR_BLACK,
            240,
            40
        );

        if (intersects)
        {
            draw_text(
                "Intersection detected!",
                COLOR_RED,
                300,
                520
            );
        }
        else
        {
            draw_text(
                "No intersection",
                COLOR_BLACK,
                330,
                520
            );
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
