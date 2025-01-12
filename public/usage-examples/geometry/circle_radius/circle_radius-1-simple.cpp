#include "splashkit.h"

int main()
{
    // Let user enter the radius
    write_line("Enter Radius for circle: ");
    double Radius = convert_to_double(read_line());

    open_window("Circle Radius", 800, 600);
    clear_screen();

    // Create a circle at the position (400, 300)
    circle circle = circle_at(400, 300, Radius);

    // Find the radius of the circle 
    double radius = circle_radius(circle);

    // Fill the Circle
    fill_circle(COLOR_RED, 400, 300, radius);
    
    // Create a rectangle to show the radius
    draw_rectangle(COLOR_WHITE, 400, 300, radius, radius);
    
    string text = "Radius: " + std::to_string(radius);
    
    // Print result on window
    draw_text(text, COLOR_BLACK, 0, 20, 100, 100);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}