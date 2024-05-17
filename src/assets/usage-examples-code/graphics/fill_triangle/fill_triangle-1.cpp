/**
 * Usage Example: Filling triangle with colour red
 **/

#include "splashkit.h"

int main()
{
    open_window("Fill Triangle Example", 800, 600);
    
    // Fill a triangle with vertices (100, 100), (200, 200), and (300, 100) with red color
    fill_triangle(COLOR_RED, 100, 100, 200, 200, 300, 100);
    
    refresh_screen();
    delay(5000); // Pause for observation
    close_all_windows();
    
    return 0;
}