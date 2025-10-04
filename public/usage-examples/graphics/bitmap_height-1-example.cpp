#include "splashkit.h"

int main()
{
    open_window("Bitmap Height", 800, 600);

    bitmap image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

    clear_screen(color_white());
    draw_bitmap(image_bitmap, 200, 155);
    draw_text("The above bitmap is " + std::to_string(bitmap_height(image_bitmap)) + " pixels in height", color_black(), 215, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}