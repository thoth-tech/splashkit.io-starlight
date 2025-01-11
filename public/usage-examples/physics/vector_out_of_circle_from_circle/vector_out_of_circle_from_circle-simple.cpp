#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Define outer circle
    circle outer_circle;
    outer_circle.center = point_at(150, 150);
    outer_circle.radius = 75;

    // Define inner circle
    circle inner_circle;
    inner_circle.center = point_at(150, 150);
    inner_circle.radius = 25;

    // Define velocity vector
    vector_2d velocity = {10, 10};

    // Calculate escape vector
    vector_2d escape = vector_out_of_circle_from_circle(inner_circle, outer_circle, velocity);

    // Create line representing the escape vector
    line vector_line = line_from(inner_circle.center, escape);

    // Clear the screen
    clear_screen();

    // Draw the circles
    fill_circle(COLOR_BLACK, outer_circle);
    fill_circle(COLOR_YELLOW, inner_circle);

    // Draw the escape vector line
    draw_line(COLOR_RED, vector_line);

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
