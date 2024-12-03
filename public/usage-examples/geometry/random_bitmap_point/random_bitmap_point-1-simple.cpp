#include "splashkit.h"

int main()
{
    // Create Window
    open_window("Random Quad Shape", 600, 600);
    bitmap bmp = create_bitmap("Random Quads", 600, 600);

    // Create quad using random points on bitmap
    quad q = quad_from(
        random_bitmap_point(bmp),
        random_bitmap_point(bmp),
        random_bitmap_point(bmp),
        random_bitmap_point(bmp));
    draw_quad_on_bitmap(bmp, color_black(), q);

    clear_screen(color_white_smoke());

    // Draw the bitmap
    draw_bitmap(bmp, 0, 0);

    refresh_screen();
    delay(5000);
    close_all_windows();

    return 0;
}
