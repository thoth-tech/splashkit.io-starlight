#include "splashkit.h"

// This program demonstrates the use of the distant_point_on_circle_heading function.
// It draws a circle and a point, then calculates and shows the farthest point
// on the circle in the direction away from the fixed point.

int main()
{
    open_window("Farthest Point", 400, 300);

    circle c = { {200, 150}, 50 };
    point_2d from = { 100, 50 };

    vector_2d heading = { from.x - c.center.x, from.y - c.center.y };

    point_2d far_point;
    distant_point_on_circle_heading(from, c, heading, far_point);

    while (!window_close_requested("Farthest Point"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_circle(COLOR_BLACK, c);
        draw_pixel(COLOR_RED, from);
        draw_pixel(COLOR_BLUE, far_point);

        refresh_screen(60);
    }

    return 0;
}
