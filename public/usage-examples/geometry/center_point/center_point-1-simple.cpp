#include "splashkit.h"

int main()
{
    open_window("Center Point", 800, 600);
    clear_screen();

    //Set position for the circle
    double x_position = 400;
    double y_position = 300;

    //Create a circle at the position (x_position, y_position)
    circle A = circle_at(x_position, y_position, 200);

    //Fill the Circle
    fill_circle(COLOR_RED, A);

    //Using the center point to fill a triangle to cut the circle
    fill_triangle(COLOR_WHITE, center_point(A).x, center_point(A).y, 0, 300, 500, 0);
    
    //Draw Point in the center of the circle
    fill_circle(COLOR_BLACK, center_point(A).x, center_point(A).y, 3);
    
    string text = "Center Point At: " + point_to_string(center_point(A));
    //Print result on window
    draw_text(point_to_string(center_point(A)), COLOR_BLACK, x_position -20, y_position - 20);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}