#include "splashkit.h"

int main()
{
    open_window("Circle X", 800, 600);
    clear_screen();

    // Set position for the circle
    // Give random  x_position value bewteen 200 - 600
    double x_position = rnd(400) + 200;
    double y_position = 300;

    // Create A circle name "A" at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);

    // Find the x position of the circle
    double circleX = circle_x(A);

    // Draw the Circle
    draw_circle(COLOR_RED, circleX, y_position, 200);

    string text = "Circle X: " + std::to_string(circleX);

    // Print result on window
    draw_text(text, COLOR_BLACK, 0, 20, 100, 100);

    refresh_screen();
    delay(4000);
    close_all_windows();
}