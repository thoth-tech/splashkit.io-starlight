#include "splashkit.h"

int main()
{
    // Open a window titled "Fill Triangle Example" with dimensions 800x600
    open_window("Fill Triangle Example", 800, 600);

    ClearScreen(ColorWhite());

    // Fill a triangle with vertices (100, 100), (200, 200), and (300, 100) with red color
    fill_triangle(COLOR_RED, 100, 100, 200, 200, 300, 100);
    
    // Refresh the screen to display the filled triangle
    refresh_screen();
    // Pause for 5000 milliseconds (5 seconds) to observe the result
    delay(5000); 

    // Close all windows
    close_all_windows();
    
    return 0;
}