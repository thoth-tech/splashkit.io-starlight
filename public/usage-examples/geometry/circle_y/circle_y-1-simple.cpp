#include "splashkit.h"

int main()
{
    open_window("Circle Y", 800, 600);
    clear_screen();

    //Set position for the circle
    double x_position = 400;
    //Give random  y_position value bewteen 200 - 400
    double y_position = rand() % 200 + 200;

    //Create a circle at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);
    // Find the Y position of the circle
    double circleY = circle_y(A);

    //Draw the Circle
    draw_circle(COLOR_RED, x_position, circleY, 200);
    
    string text = "Circle Y: " + std::to_string(circleY);
    //Print result on window
    draw_text(text, COLOR_BLACK, 0, 20, 100, 100);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}