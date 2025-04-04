#include "splashkit.h"

int main() 
{
    // Open a window with the title "Option Flip X"  
    open_window("Option Flip X", 600, 600);

    // Load a bitmap image named "Player" from the file "character.png"
    bitmap bmp = load_bitmap("Player", "character.png");

    // Draw the original bitmap image at position (100, 300)
    draw_bitmap(bmp, 100, 300);

    // Draw the bitmap image flipped horizontally at position (500, 300)
    draw_bitmap(bmp, 500, 300, option_flip_x());

    // Refresh the screen to display the drawings
    refresh_screen();

    // Wait for 5 seconds before closing the window
    delay(5000);

    // Close all open windows
    close_all_windows();

    return 0;
}
