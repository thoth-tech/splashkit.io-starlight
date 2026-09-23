#include "splashkit.h"
#include <string>

int main()
{
    open_window("Distance from Mouse to Line", 800, 600);

    // Use one fixed line and let the mouse act as the test point
    line demo_line = line_from(150, 300, 650, 300);

    while (!quit_requested())
    {
        process_events();

        // Measure how far the mouse point is from the line
        point_2d pt = mouse_position();
        float distance = point_line_distance(pt, demo_line);

        clear_screen(COLOR_WHITE);

        // Draw the line, the point, and the measured distance
        draw_line(COLOR_BLACK, demo_line);
        fill_circle(COLOR_RED, pt.x, pt.y, 6);

        draw_text("Move the mouse to change the point.", COLOR_BLACK, 20, 20);
        draw_text("Distance from point to line: " + std::to_string(distance), COLOR_BLUE, 20, 50);

        refresh_screen(60);
    }

    return 0;
}