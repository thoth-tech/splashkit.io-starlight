/**
 * Usage Example: using function fill_triangle_on_bitmap with colour red
 **/

#include "splashkit.h"

int main()
{
    // Open a window titled "Fill Triangle On Bitmap Example" with dimensions 800x600
    open_window("Fill Triangle On Bitmap Example", 800, 600);

    // Create a bitmap named "triangle_bitmap" with dimensions 800x600
    bitmap my_bitmap = create_bitmap("triangle_bitmap", 800, 600);

    // Fill the triangle on the bitmap with red color
    fill_triangle_on_bitmap(my_bitmap, COLOR_RED, 100, 100, 200, 200, 300, 100);

    // Draw the bitmap to the screen
    draw_bitmap(my_bitmap, 0, 0);

    // Refresh the screen to display the filled triangle on the bitmap
    refresh_screen();

    // Pause for 5000 milliseconds (5 seconds) to observe the result
    delay(5000);

    // Close all windows
    close_all_windows();

    return 0;
}

