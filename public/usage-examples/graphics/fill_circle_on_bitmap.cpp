#include "splashkit.h"

// A simplified and more explicit variant, guiding students to build on SplashKit principles

void draw_surface_details(bitmap &bmp, color c)
{
    for (int i = 0; i < 15; i++)
    {
        double x = rnd(100, 300);
        double y = rnd(100, 300);
        double radius = rnd(10, 30);
        draw_circle_on_bitmap(bmp, c, x, y, radius);
    }
}

int main()
{
    // Set up window and bitmap
    window window = open_window("Beyond SplashKit - Circle on Bitmap", 400, 400);
    bitmap surface = create_bitmap("surface", 400, 400);
    clear_bitmap(surface, COLOR_BLACK);

    // Draw base and overlay
    color main_color = rgba_color(180, 0, 0, 255);
    fill_circle_on_bitmap(surface, main_color, 200, 200, 150);
    draw_circle_on_bitmap(surface, COLOR_RED, 200, 200, 150);

    // Add custom surface detail
    draw_surface_details(surface, COLOR_RED);

    // Render loop
    while (!window_close_requested(window))
    {
        process_events();
        draw_bitmap(surface, 0, 0);
        refresh_screen();
    }

    // Clean up
    free_bitmap(surface);
    close_all_windows();
    return 0;
}
