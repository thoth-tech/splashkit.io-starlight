// This example demonstrates the use of SplashKit’s line_from(Point2D, Vector2D) function
#include "splashkit.h"

int main()
{
    // Open a graphics window
    open_window("Vector Field with line_from", 800, 600);
    clear_screen(COLOR_WHITE);

    // Define the offset vector used in all lines
    vector_2d direction = vector_to(20.0, 10.0);

    // Define grid spacing
    int step_x = 80;
    int step_y = 60;

    // Draw lines across the screen from grid points using the offset vector
    for (int x = 0; x < screen_width(); x += step_x)
    {
        for (int y = 0; y < screen_height(); y += step_y)
        {
            point_2d start = point_at((double)x, (double)y);     // Start point of line
            line segment = line_from(start, direction);          // Create line from start using vector
            draw_line(COLOR_GREEN, segment);                     // Draw the line
        }
    }

    // Display the result
    refresh_screen();
    delay(5000);  // Keep the window open for 5 seconds

    return 0;
}