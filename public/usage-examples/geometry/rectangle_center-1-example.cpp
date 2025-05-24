#include "splashkit.h"

// Declare a variable with snake_case
string example_message = "this is an example of snake_case";

int main()
{
    // Open a graphics window
    open_window("Spotlight on Center", 600, 400);

    // Define a rectangle using top-left corner and size
    rectangle example_rectangle = rectangle_from(100, 100, 200, 150);

    // Calculate the center point of the rectangle
    point_2d center_point = rectangle_center(example_rectangle);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the rectangle in blue
        draw_rectangle(
            COLOR_BLUE,
            example_rectangle.x,
            example_rectangle.y,
            example_rectangle.width,
            example_rectangle.height
        );

        // Draw a red circle at the center point
        fill_circle(COLOR_RED, center_point, 5);

        // Label the center point
        draw_text("Center", COLOR_BLACK, "Arial", 12, center_point.x + 8, center_point.y - 6);

        refresh_screen();
    }

    // Close the window
    close_window("Spotlight on Center");

    return 0;
}
