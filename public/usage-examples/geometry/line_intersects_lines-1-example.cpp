#include "splashkit.h"

int main()
{
    open_window("Line Intersection Demo", 800, 600);
    
    // Defining two lines
    line lineA = line_from(100, 100, 300, 300); // Diagonal
    line lineB = line_from(300, 100, 100, 300); // Crossing

    // Checking for intersection
    bool intersects = line_intersects_lines(lineA, { lineB });


    // Drawing the lines
    clear_screen(COLOR_WHITE);
    draw_line(COLOR_RED, lineA);
    draw_line(COLOR_BLUE, lineB);

    // Display result
    if (intersects)
    {
        draw_text("Lines Intersect", COLOR_GREEN, 320, 550);
    }
    else
    {
        draw_text("Lines Do Not Intersect", COLOR_BLACK, 320, 550);
    }

    refresh_screen();

    delay(4000); // Show result for 4 seconds
    return 0;
}
