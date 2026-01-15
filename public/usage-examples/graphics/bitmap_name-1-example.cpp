#include "splashkit.h"

int main()
{
    open_window("Bitmap Name", 800, 600);

    bitmap image_bitmap = load_bitmap("insert_name_here", "image1.jpg");

    clear_screen(color_white());
    draw_bitmap(image_bitmap, 200, 155);
    draw_text("The name of the above bitmap is '" + bitmap_name(image_bitmap) + "'", color_black(), 215, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}