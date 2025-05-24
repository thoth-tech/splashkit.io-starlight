#include "splashkit.h"

// Declare a variable with snake_case
string example_message = "this is an example of snake_case";

int main()
{
    // Open a graphics window with a descriptive name
    open_window("Framed and Labeled", 600, 400);

    // Create a rectangle with specified position and size
    rectangle example_rectangle = rectangle_from(100, 150, 200, 120);

    // Convert the rectangle to a string representation
    string rectangle_text = rectangle_to_string(example_rectangle);

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

        // Draw the rectangle’s string representation in black
        draw_text(rectangle_text, COLOR_BLACK, "Arial", 14, 20, 20);

        refresh_screen();
    }

    // Close the graphics window
    close_window("Framed and Labeled");

    return 0;
}
