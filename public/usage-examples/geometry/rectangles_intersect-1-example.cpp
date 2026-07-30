#include "splashkit.h"

int main()
{
    open_window("Rectangle Intersection Demo", 800, 600);

    rectangle fixed_rectangle = rectangle_from(300, 220, 200, 120);

    while (!quit_requested())
    {
        process_events();

        // Move the second rectangle with the mouse to test for intersections.
        rectangle movable_rectangle = rectangle_from(
            mouse_x() - 75,
            mouse_y() - 50,
            150,
            100
        );

        // Determine if the rectangles are intersecting.
        bool is_intersecting = rectangles_intersect(
            fixed_rectangle,
            movable_rectangle
        );

        clear_screen(COLOR_WHITE);

        if (is_intersecting)
        {
            fill_rectangle(COLOR_RED, fixed_rectangle);
            fill_rectangle(COLOR_RED, movable_rectangle);

            draw_text(
                "Rectangles are intersecting.",
                COLOR_BLACK,
                240,
                60
            );
        }
        else
        {
            fill_rectangle(COLOR_BLUE, fixed_rectangle);
            fill_rectangle(COLOR_GREEN, movable_rectangle);

            draw_text(
                "Move the green rectangle with the mouse.",
                COLOR_BLACK,
                185,
                60
            );
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}