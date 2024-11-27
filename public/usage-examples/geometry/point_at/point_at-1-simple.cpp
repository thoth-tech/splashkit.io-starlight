#include "splashkit.h"

int main()
{
    open_window("Point At", 800, 600);
    clear_screen();

    // Create circle at the point
    fill_circle(COLOR_RED, 400, 300, 4);

    // Create a point at position (400,300)
    point_2d Point = point_at(400,300);
    
    refresh_screen();
    delay(4000);
    close_all_windows();
}