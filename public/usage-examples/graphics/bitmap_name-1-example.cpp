#include "splashkit.h"

int main()
{
    // Open a window titled "Bitmap Named Example" with fixed dimensions
    open_window("Bitmap Named Example", 800, 600);

    // Load a bitmap from file and assign it the name "logo"
    load_bitmap("logo", "splashkit.png");

    // Retrieve the bitmap using its assigned name
    bitmap image = bitmap_named("logo");

    // Calculate the position to center the bitmap in the window
    int x = (800 - bitmap_width(image)) / 2;
    int y = (600 - bitmap_height(image)) / 2;

    // Clear the screen with white for better contrast
    clear_screen(COLOR_WHITE);

    // Draw the bitmap centered in the window
    draw_bitmap(image, x, y);

    // Output the bitmap name to the terminal for reference
    write_line("Bitmap name: " + bitmap_name(image));

    // Display the rendered frame
    refresh_screen();

    // Pause for 3 seconds before closing
    delay(3000);

    return 0;
}