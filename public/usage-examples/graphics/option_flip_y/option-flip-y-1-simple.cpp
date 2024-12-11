#include "splashkit.h"

int main() 
{
    // Open a window with the title "Option Flip Y" and dimensions 800x600
    open_window("Option Flip Y", 800, 600);

    // Load a bitmap image named "Landscape" from the file "landscape.png"
    bitmap bmp = load_bitmap("Landscape", "landscape.png");

    // Draw the original bitmap image at position (100, 100)
    draw_bitmap(bmp, 100, 100);

    // Draw the bitmap image flipped both horizontally and vertically at position (300, 100)
    draw_bitmap(bmp, 300, 100, option_flip_y());

    // Refresh the screen to display the drawings
    refresh_screen();

    // Wait for 5 seconds before closing the window
    delay(5000);

    // Close all open windows
    close_all_windows();

    return 0;
}
