#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Define the inner rectangle
    rectangle inner_rectangle;
    inner_rectangle.x = 125;
    inner_rectangle.y = 125;
    inner_rectangle.width = 50;
    inner_rectangle.height = 50;

    // Define the outer rectangle
    rectangle outer_rectangle;
    outer_rectangle.x = 75;
    outer_rectangle.y = 75;
    outer_rectangle.width = 150;
    outer_rectangle.height = 150;

    // Define the velocity vector
    vector_2d velocity = {10, 10};

    // Calculate the escape vector
    vector_2d escape = vector_out_of_rect_from_rect(inner_rectangle, outer_rectangle, velocity);

    // Define the origin point
    point_2d origin = {150, 150};

    // Create a line representing the escape vector
    line vector_line = line_from(origin, escape);

    // Clear the screen and draw shapes
    clear_screen();
    fill_rectangle(COLOR_RED, outer_rectangle);
    fill_rectangle(COLOR_BLACK, inner_rectangle);

    // Draw the escape vector line
    draw_line(COLOR_BLUE, vector_line);

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
