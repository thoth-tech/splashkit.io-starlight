

#include "splashkit.h"

int main()
{
    // Open a window titled "Fill Triangle With Options Example" with dimensions 800x600
    open_window("Fill Triangle With Options Example", 800, 600);

    // Initialize drawing options with default settings
    drawing_options opts = option_defaults();
    
    // Set the scale to 1.5 (150%)
    opts.scale_x = 1.5;
    opts.scale_y = 1.5;

    // Define the vertices of the triangle
    double x1 = 100, y1 = 100;
    double x2 = 200, y2 = 200;
    double x3 = 300, y3 = 100;

    // Scale each vertex of the triangle
    double scaled_x1 = x1 * opts.scale_x;
    double scaled_y1 = y1 * opts.scale_y;
    double scaled_x2 = x2 * opts.scale_x;
    double scaled_y2 = y2 * opts.scale_y;
    double scaled_x3 = x3 * opts.scale_x;
    double scaled_y3 = y3 * opts.scale_y;

    // Fill the scaled triangle with red color
    fill_triangle(COLOR_RED, scaled_x1, scaled_y1, scaled_x2, scaled_y2, scaled_x3, scaled_y3, opts);

    // Refresh the screen to display the filled scaled triangle
    refresh_screen();

    // Pause for 5000 milliseconds (5 seconds) to observe the result
    delay(5000);

    // Close all windows
    close_all_windows();

    return 0;
}

