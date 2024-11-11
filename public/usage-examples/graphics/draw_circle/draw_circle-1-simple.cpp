#include "splashkit.h"

int main()
{
    open_window("Draw Circles", 800, 600);

    clear_screen();

    // Define the center of the circles
    point_2d center = {400, 300};

    // Create 4 circles with different radii
    circle c1 = {center, 50};
    circle c2 = {center, 100};
    circle c3 = {center, 150};
    circle c4 = {center, 200};

    // Draw the circles
    draw_circle(COLOR_RED, c1);
    draw_circle(COLOR_BLUE, c2);
    draw_circle(COLOR_ORANGE, c3);
    draw_circle(COLOR_GREEN, c4);

    refresh_screen();

    delay(4000);

    close_all_windows();

    return 0;
}