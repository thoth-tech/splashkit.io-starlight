#include "splashkit.h"

int main()
{
    open_window("Point Point Angle", 800, 600);
    clear_screen();

    // Draw the circle at the origin point
    fill_circle(COLOR_RED, 400, 300, 2);

    // Define the origin point
    point_2d originPoint = point_at(400,300);
    refresh_screen();

    while(!quit_requested())
    {
        // Get the current mouse position 
        point_2d mouse = mouse_position();

        // Calculate the angle between the origin point and the mouse position
        float angle = point_point_angle(originPoint, mouse);
        // Print angle 

        write_line(angle);
        
        delay(100);
    }

    close_all_windows();
}