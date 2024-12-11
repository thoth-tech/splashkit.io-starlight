#include "splashkit.h"

int main() 
{
    // Open a window
    open_window("Reset Clip", 800, 600);

    // Define the clipping area
    rectangle rect = {100, 100, 600, 400};

    // Push a clipping area
    set_clip(rect);
    
    // Draw inside the clipping area (it will be clipped)
    fill_rectangle(COLOR_BLUE, 50, 50, 700, 500);
    refresh_screen();  // Refresh screen to apply the drawing
    delay(1000);

    

    // Draw outside the clipping area (this won't be clipped)
    fill_rectangle(COLOR_RED, 100, 100, 200, 200);
    refresh_screen();  // Refresh screen to show the changes
    delay(1000);

    // Restore the full window area
    reset_clip();  // This command clears the clipping area

    // Clear screen and show changes
    clear_screen(color_green());  // Change background color
    refresh_screen();  // Refresh the screen to apply the change
    delay(5000);  // Wait for 5 seconds

    // Close all windows
    close_all_windows();

    return 0;
}
