#include "splashkit.h"

int main()
{
    open_window("Line intersects Circle", 800, 600);

    // Define a circle

    circle c = circle_at(400, 300, 50);

    // Define a line

    point_2d start_point = {100, 100};
    point_2d end_point = {700, 500};



    // Draw the circle
    draw_circle(COLOR_RED, c);

    // Draw the line
    line l = line_from(start_point, end_point);
    draw_line(COLOR_BLUE, l);

    // Check for intersection
    bool intersects = line_intersects_circle(l, c);

    // Display result
    if (intersects)
    {
        draw_text("Intersecting", COLOR_GREEN, "Arial", 50, 20, 30);
    }
    else
    {
        draw_text("Not Intersecting", COLOR_RED, "Arial", 50, 20, 30);
    }

    refresh_screen();

    delay(5000);
    return 0;
}