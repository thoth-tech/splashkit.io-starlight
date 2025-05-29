#include "splashkit.h"

int main()
{
    // open a window
    open_window("Line Intersects Lines - Interactive Demo", 800, 600);

    // create three static lines to check for intersection
    line line1 = line_from(100, 150, 700, 150);
    line line2 = line_from(100, 300, 700, 300);
    line line3 = line_from(100, 450, 700, 450);

    vector<line> lines_to_check = { line1, line2, line3 };

    while (!quit_requested())
    {
        process_events();

        // intersecting line from origin to mouse position
        line intersectingLine = line_from(0, 0, mouse_x(), mouse_y());

        clear_screen(COLOR_WHITE);

        draw_line(COLOR_RED, intersectingLine);

        // flag to indicate if the intersecting line touches any static line
        bool any_intersection = false;

        for (line l : lines_to_check)
        {
            if (lines_intersect(intersectingLine, l))
            {
                draw_line(COLOR_GREEN, l); // intersecting
                any_intersection = true;
            }
            else
            {
                draw_line(COLOR_BLACK, l); // not intersecting
            }
        }

        if (any_intersection)
        {
            draw_text("Intersection Detected!", COLOR_GREEN, 20, 20);
        }
        else
        {
            draw_text("No Intersection", COLOR_GRAY, 20, 20);
        }

        draw_text("Move mouse to test intersections", COLOR_BLACK, 20, 570);
        refresh_screen();
    }

    return 0;
}
