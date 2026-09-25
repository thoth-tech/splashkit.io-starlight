#include "splashkit.h"

int main()
{
    open_window("Line Intersects Circle", 800, 600);

    circle demo_circle = circle_at(400, 300, 120);

    while (!quit_requested())
    {
        process_events();

        // Create a line from a fixed point to the mouse position
        point_2d start_pt = point_at(100, 300);
        point_2d end_pt = mouse_position();

        line demo_line = line_from(start_pt, end_pt);

        // Check if the line intersects the circle
        bool intersects = line_intersects_circle(demo_line, demo_circle);

        clear_screen(COLOR_WHITE);

        // Draw the circle
        draw_circle(COLOR_BLACK, demo_circle);

        // Draw the line based on intersection result
        if (intersects)
        {
            draw_line(COLOR_GREEN, demo_line);
            draw_text("The line intersects the circle.", COLOR_GREEN, 20, 20);
        }
        else
        {
            draw_line(COLOR_RED, demo_line);
            draw_text("The line does not intersect the circle.", COLOR_RED, 20, 20);
        }

        refresh_screen(60);
    }

    return 0;
}