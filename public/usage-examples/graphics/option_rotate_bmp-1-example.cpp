#include "splashkit.h"

int main()
{
    open_window("Option Rotate Bmp", 800, 600);

    bitmap image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

    clear_screen(color_white());
    // Function used here ↓
    draw_bitmap(image_bitmap, 200, 130, option_rotate_bmp(10));
    draw_text("This bitmap has been rotated by +10 degrees", color_black(), 215, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}