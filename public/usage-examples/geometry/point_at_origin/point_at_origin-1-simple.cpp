#include "splashkit.h"

int main()
{
    open_window("Point At Origin", 800, 600);
    clear_screen();

    // Create a point at origin
    point_2d Point = point_at_origin();

    // Create circle at the origin point
    fill_circle(COLOR_RED, Point.x, Point.y, 4);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}