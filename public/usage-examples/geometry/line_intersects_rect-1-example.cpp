#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Line Intersects Rect", 800, 600);

    // Define a draggable line
    point_2d start_pt = point_at(100, 100);
    point_2d end_pt = point_at(700, 500);
    line line = line_from(start_pt, end_pt);

    // Define a static rectangle
    rectangle rect;
    rect.x = 300;
    rect.y = 200;
    rect.width = 200;
    rect.height = 150;

    while (!quit_requested())
    {
        process_events();

        // Move the line ends with mouse
        if (mouse_down(LEFT_BUTTON))
        {
            if (point_in_circle(mouse_position(), circle_at(start_pt, 10)))
            {
                start_pt = mouse_position();
            }
            else if (point_in_circle(mouse_position(), circle_at(end_pt, 10)))
            {
                end_pt = mouse_position();
            }
        }

        // Update the line
        line = line_from(start_pt, end_pt);

        // Check for intersection
        bool intersects = line_intersects_rect(line, rect);

        clear_screen(COLOR_WHITE);

        // Draw the rectangle
        draw_rectangle(COLOR_BLUE, rect);

        // Draw the line
        draw_line(COLOR_BLACK, line);

        // Draw draggable points
        draw_circle(COLOR_GREEN, start_pt.x, start_pt.y, 5);
        draw_circle(COLOR_GREEN, end_pt.x, end_pt.y, 5);

        // Show text when intersecting
        if (intersects)
        {
            draw_text("Intersecting", COLOR_RED, "Arial", 20, 10, 10);
        }

        refresh_screen();
    }

    return 0;
}
