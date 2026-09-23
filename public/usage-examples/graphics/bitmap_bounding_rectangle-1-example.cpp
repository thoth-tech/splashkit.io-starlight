#include "splashkit.h"

int main()
{
    open_window("Bitmap Bounding Rectangle", 800, 600);

    bitmap vertical_bitmap = load_bitmap("vertical_bitmap", "image1.jpeg");
    bitmap horizontal_bitmap = load_bitmap("horizontal_bitmap", "image2.png");
    // Function used here ↓
    rectangle vertical_rectangle = bitmap_bounding_rectangle(vertical_bitmap);
    rectangle horizontal_rectangle = bitmap_bounding_rectangle(horizontal_bitmap);

    vertical_rectangle.x = 212;
    vertical_rectangle.y = 50;
    horizontal_rectangle.x = 150;
    horizontal_rectangle.y = 400;

    process_events();

    clear_screen(color_white());
    draw_bitmap(vertical_bitmap, 450, 50);
    draw_rectangle(color_black(), vertical_rectangle);
    draw_bitmap(horizontal_bitmap, 450, 400);
    draw_rectangle(color_black(), horizontal_rectangle);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}