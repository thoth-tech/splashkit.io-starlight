#include "splashkit.h"

int main()
{
    // Open a new window with the title "Sprite Extraction" and dimensions 800x600
    open_window("Sprite Extraction", 800, 600);

    // Load the bitmap from the file "sprite.png" and give it the name "Sprite"
    bitmap bmp = load_bitmap("Sprite", "sprite.png");

    // Draw a specific part of the bitmap onto the window at coordinates (100, 100)
    // The part drawn starts at (70, 90) in the bitmap and has a width and height of 200x200
    draw_bitmap(bmp, 100, 100, option_part_bmp(70, 90, 200, 200));

    // Refresh the screen to display the changes
    refresh_screen();

    // Pause the program for 5000 milliseconds (5 seconds)
    delay(5000);

    // Close all open windows
    close_all_windows();

    return 0;
}
