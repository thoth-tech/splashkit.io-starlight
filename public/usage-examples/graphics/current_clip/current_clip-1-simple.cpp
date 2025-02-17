#include "splashkit.h"

int main() 
{
    // Open a window with the title "Current Clip" and dimensions
    window window = open_window("Current Clip", 800, 600);

    // Define the clipping area
    rectangle rect = current_clip(window);

    // Draw the clipping information
    draw_text("Current Clip: " + std::to_string(rect.width) + " X " + std::to_string(rect.height), COLOR_BLACK, "Arial", 24, 100, 100);
    
    // Refresh the screen to display the text
    refresh_screen();

    // Wait for 5 seconds
    delay(5000);

    // Close all windows
    close_all_windows();

    return 0;
}
