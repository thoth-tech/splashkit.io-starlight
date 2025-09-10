#include "splashkit.h"

int main()
{
    window window = open_window("Closest Point On Line", 800, 600);

    // Create line for which our point will be attached to
    line diagonal_line = line_from(200, 150, 600, 450);

    while (!window_close_requested(window))
    {
        process_events();
        clear_screen(COLOR_WHITE);
        draw_line(COLOR_BLACK, diagonal_line);

        // Use our mouse position for calculating the closest point on line
        point_2d mouse_pos = point_at(mouse_x(), mouse_y());
        point_2d closest = closest_point_on_line(mouse_pos, diagonal_line);

        // Visualize the mouse position and the closest point on the line
        fill_circle(COLOR_RED, mouse_pos.x, mouse_pos.y, 5);
        fill_circle(COLOR_GREEN, closest.x, closest.y, 5);

        refresh_screen();
    }

    return 0;
}
