#include "splashkit.h"

int main()
{
    open_window("Point At Origin", 800, 600);
    clear_screen();

    // Create circle at the origin point
    fill_circle(COLOR_RED, 0, 0, 4);

    // Create a point at origin
    point_2d Point = point_at_origin();
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}