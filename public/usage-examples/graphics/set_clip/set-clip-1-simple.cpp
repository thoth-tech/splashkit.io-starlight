#include "splashkit.h"

int main() 
{
    // Open a window with the title "Set Clip" and dimensions of 800x600 pixels
    open_window("Set Clip", 800, 600);

    // Define a clipping area with a rectangle (x, y, width, height)
    rectangle rect = {100, 100, 600, 400};

    // Set the clipping area to restrict drawing to the specified rectangle
    set_clip(rect);

    // Draw a large rectangle; since it exceeds the clipping area, it will be clipped
    fill_rectangle(COLOR_BLUE, 50, 50, 700, 500);

    // Refresh the screen to display the drawing
    refresh_screen();

    // Wait for 5 seconds to observe the effect of the clipping
    delay(5000);

    // Close the window
    close_all_windows();

    return 0;
}
