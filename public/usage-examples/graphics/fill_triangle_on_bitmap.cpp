#include "splashkit.h"

int main()
{
    // Create a bitmap to draw on
    bitmap triangle_bmp = create_bitmap("triangle", 618, 618);

    // Clear the bitmap with white
    clear_bitmap(triangle_bmp, COLOR_WHITE);

    // Define triangle coordinates
    double x1 = 100, y1 = 200;
    double x2 = 309, y2 = 20;
    double x3 = 520, y3 = 200;

    // Draw filled triangle on the bitmap
    fill_triangle_on_bitmap(triangle_bmp, COLOR_RED, x1, y1, x2, y2, x3, y3);

    // Show bitmap in a window
    open_window("Fill Triangle on Bitmap", 618, 618);
    draw_bitmap(triangle_bmp, 0, 0);
    refresh_screen();

    // Keep window open for 5 seconds
    delay(5000);

    return 0;
}
