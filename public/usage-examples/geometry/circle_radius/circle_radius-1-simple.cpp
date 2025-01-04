#include "splashkit.h"

int main()
{
    open_window("Circle Radius", 800, 600);
    clear_screen();

    // Set position for the circle
    double x_position = 400;
    double y_position = 300;

    // Create a circle A at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);

    // Find the radius of the circle A
    double radius = circle_radius(A);

    // Fill the Circle
    fill_circle(COLOR_RED, x_position, y_position, radius);
    //Use the radius to create a rectangle to cut 1/4 of the circle
    fill_rectangle(COLOR_WHITE, x_position, y_position , radius, radius);
    
    string text = "Radius: " + std::to_string(radius);
    // Print result on window
    draw_text(text, COLOR_BLACK, 0, 20, 100, 100);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}