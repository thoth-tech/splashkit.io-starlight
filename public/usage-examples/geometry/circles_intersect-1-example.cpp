#include "splashkit.h"

int main()
{
    open_window("Circle Intersection Demo", 800, 600);

    circle fixed_circle = circle_at(350, 280, 100);

    while (!quit_requested())
    {
        process_events();

        // Move the second circle with the mouse to test for intersections.
        circle movable_circle = circle_at(mouse_x(), mouse_y(), 70);

        // Check whether the two circles intersect.
        bool is_intersecting = circles_intersect(fixed_circle, movable_circle);

        clear_screen(COLOR_WHITE);

        if (is_intersecting)
        {
            fill_circle(COLOR_RED, fixed_circle);
            fill_circle(COLOR_RED, movable_circle);
            draw_text("Circles are intersecting!", COLOR_BLACK, 20, 20);
        }
        else
        {
            fill_circle(COLOR_BLUE, fixed_circle);
            fill_circle(COLOR_GREEN, movable_circle);
            draw_text("Circles are not intersecting.", COLOR_BLACK, 20, 20);
        }

        draw_text("Move the mouse-controlled circle over the fixed circle.", COLOR_BLACK, 20, 550);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}