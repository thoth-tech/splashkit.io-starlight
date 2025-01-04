#include "splashkit.h"

int main()
{
    open_window("Circle At", 800, 600);
    clear_screen();

    //Set position for the circle
    double x_position = 400;
    double y_position = 300;

    //Create a circle at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);

    //Draw the Circle
    draw_circle(COLOR_RED, A);
    
    string text = "Circle At: (400,300), Radius: 200";
    //Print result on window
    draw_text(text, COLOR_BLACK, 0, 20, 100, 100);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}