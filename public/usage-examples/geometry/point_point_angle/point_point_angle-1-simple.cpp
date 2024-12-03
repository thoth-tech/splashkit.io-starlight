#include "splashkit.h"

int main()
{
    open_window("Point point angle", 800, 600);
    clear_screen();

    // Create circle at the point
    fill_circle(COLOR_RED, 400, 300, 2);

    // Origin piont
    point_2d originPoint = point_at(400,300);
    refresh_screen();

    while(!quit_requested())
    {
        // Point of mouse 
        point_2d mouse = mouse_position();

        //Calculate angle between original point and mouse
        float angle = point_point_angle(originPoint, mouse);
        // Print angle 
        write_line(angle);
        delay(100);
    }

    close_all_windows();
}