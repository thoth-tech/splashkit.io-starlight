#include "splashkit.h"

int main()
{
    open_window("Option Rotate Bmp", 800, 600);

    bitmap image_bitmap = load_bitmap("image_bitmap", "image1.jpg");
    int bitmap_rotation = 10;

    clear_screen(color_white());
    draw_bitmap(image_bitmap, 200, 130, option_rotate_bmp(bitmap_rotation));
    draw_text("This bitmap has been rotated by " + std::to_string(bitmap_rotation) + " degrees", color_black(), 215, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}