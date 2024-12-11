#include "splashkit.h"

int main() 
{
    // Open a window with the title "Pop Clip" and dimensions 800x600
    open_window("Pop Clip", 800, 600);

    // Define the clipping area starting at (100, 100) with width 600 and height 400
    rectangle rect = {100, 100, 600, 400};

    // Push a clipping area to restrict drawing to within the defined rectangle
    push_clip(rect);

    // Draw a blue rectangle inside the clipping area (this will be affected by clipping)
    fill_rectangle(COLOR_BLUE, 50, 50, 700, 500);

    // Restore the full window area after clipping
    pop_clip();

    // Draw a red rectangle outside the clipping area (this won't be affected by clipping)
    fill_rectangle(COLOR_RED, 100, 100, 200, 200);

    // Refresh the screen to display the changes
    refresh_screen();

    // Wait for 5 seconds before closing the window
    delay(5000);

    // Close all open windows to end the program
    close_all_windows();

    return 0;
}
