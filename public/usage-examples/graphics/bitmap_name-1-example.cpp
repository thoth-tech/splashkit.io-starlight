#include "splashkit.h"

int main()
{
    bitmap my_image = load_bitmap("logo", "splashkit.png");
    string name = bitmap_name(my_image);

    open_window("Bitmap Name Example", 800, 600);

    // Calculate center position
    int x = (800 - bitmap_width(my_image)) / 2;
    int y = (600 - bitmap_height(my_image)) / 2;

    // Draw the image to the center
    draw_bitmap(my_image, x, y);

    write_line("Bitmap name: " + name);
    
    refresh_screen();
    delay(3000);

    return 0;
}