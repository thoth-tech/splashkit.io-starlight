// I am demonstrating creating, animating, and freeing a bitmap with a new color each load.
// L loads (creates) the bitmap in a random color; F frees it; ESC quits.

#include "splashkit.h"
#include <cmath>
#include <cstdio>

int main()
{
    const int window_width = 720;
    const int window_height = 405;
    open_window("Free Bitmap - load, animate, free", 720, 405);

    bitmap demo = nullptr;
    bool loaded = false;
    int load_count = 0;
    double t = 0.0;

    // I am (re)creating a simple colored bitmap using SplashKit's random_color()
    auto make_demo = [&]()
    {
        demo = create_bitmap("demo_bmp", 96, 96);
        const color c = random_color();
        fill_rectangle_on_bitmap(demo, c, 0, 0, 96, 96);
        draw_rectangle_on_bitmap(demo, rgb_color(0, 0, 0), 0, 0, 96, 96);
        loaded = true;
        load_count = load_count + 1;
    };

    while (!quit_requested())
    {
        process_events();

        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(L_KEY))
        {
            if (loaded)
            {
                free_bitmap(demo);
                loaded = false;
            }
            make_demo();
        }
        if (key_typed(F_KEY))
        {
            if (loaded)
            {
                free_bitmap(demo);
                loaded = false;
            }
        }

        clear_screen(rgb_color(255, 255, 255));

        if (loaded)
        {
            // I am animating with a gentle vertical bob
            t = t + 0.06;
            const int cx = window_width / 2 - 48;
            const int cy = window_height / 2 - 48 + (int)(8.0 * std::sin(t));

            draw_text("Status: Loaded  |  L: load  F: free  ESC: quit",
                      rgb_color(0, 0, 0), 16, 16);

            char label[64];
            std::snprintf(label, sizeof(label), "Loads: %d", load_count);
            draw_text(label, rgb_color(0, 0, 0), window_width - 110, 16);

            draw_bitmap(demo, cx, cy);
        }
        else
        {
            draw_text("Status: Freed  |  L: load  F: free  ESC: quit",
                      rgb_color(0, 0, 0), 16, 16);
            draw_rectangle(rgb_color(128, 128, 128),
                           window_width / 2 - 48, window_height / 2 - 48, 96, 96);
            draw_text("Freed", rgb_color(128, 128, 128),
                      window_width / 2 - 20, window_height / 2 - 8);
        }

        refresh_screen(60);
    }

    if (loaded)
    {
        free_bitmap(demo);
    }
    return 0;
}