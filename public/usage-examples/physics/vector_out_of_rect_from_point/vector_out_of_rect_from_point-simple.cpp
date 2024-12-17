#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Define the outer rectangle
    rectangle outer_rectangle;
    outer_rectangle.x = 75;
    outer_rectangle.y = 75;
    outer_rectangle.width = 150;
    outer_rectangle.height = 150;

    // Define the escape point
    point_2d escape_point = {150, 150};

    // Define velocity vector
    vector_2d velocity = {10, 10};

    // Calculate the escape vector
    vector_2d escape = vector_out_of_rect_from_point(escape_point, outer_rectangle, velocity);

    // Create a line representing the escape vector
    line vector_line = line_from(escape_point, escape);

    // Clear the screen and draw shapes
    clear_screen();
    fill_rectangle(COLOR_BLACK, outer_rectangle);
    fill_circle(COLOR_YELLOW, circle_at(escape_point, 3));

    // Draw the escape vector line
    draw_line(COLOR_RED, vector_line);

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
