#include "splashkit.h"

int main() 
{
    // Open a window with the specified title and dimensions
    open_window("Push Clip", 800, 600);

    // Define a rectangular clipping area starting at (100, 100) with width 200 and height 200
    rectangle rect = {100, 100, 200, 200};

    // Push a clipping area onto the window
    push_clip(rect);
    
    // Draw a blue rectangle inside the clipping area (this will be clipped)
    fill_rectangle(COLOR_BLUE, 50, 50, 300, 300);   

    // Pop the clipping area to restore full screen drawing
    pop_clip();

    // Draw a red rectangle outside the clipping area (this will not be clipped)
    fill_rectangle(COLOR_RED, 300, 300, 200, 200);

    // Refresh the screen to display the drawing
    refresh_screen();

    // Wait for 5 seconds to observe the changes
    delay(5000);

    // Close all open windows
    close_all_windows();

    return 0;
}
