// I am scaling a bitmap at draw time with option_scale_bmp.
// A makes smaller; D makes bigger; R resets; SPACE toggles outline; ESC quits.

#include "splashkit.h"
#include <cstdio>

static bitmap make_sticker()
{
    // I am creating a small procedural bitmap so no external file is needed
    const int w = 128;
    const int h = 128;
    bitmap bmp = create_bitmap("sticker", w, h);
    clear_bitmap(bmp, rgba_color(255, 255, 255, 0)); // transparent

    // I am drawing a light grid
    for (int y = 0; y < h; y += 16)
    {
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), 0, y, w, y);
    }
    for (int x = 0; x < w; x += 16)
    {
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), x, 0, x, h);
    }

    // I am drawing a friendly circle and a border
    fill_circle_on_bitmap(bmp, rgb_color(33, 150, 243), w / 2, h / 2, 36);
    draw_circle_on_bitmap(bmp, COLOR_BLACK, w / 2, h / 2, 36);
    draw_rectangle_on_bitmap(bmp, COLOR_BLACK, 1, 1, w - 2, h - 2);

    return bmp;
}

int main()
{
    const int window_width = 800;
    const int window_height = 480;
    open_window("Option Scale Bmp — live scaling", window_width, window_height);

    bitmap sticker = make_sticker();

    // I am keeping scale as a double
    double scale = 1.0;
    const double step = 0.1;
    const double min_scale = 0.2;
    const double max_scale = 3.0;

    bool show_outline = true;

    // I am centering the draw position
    const double cx = window_width / 2.0;
    const double cy = window_height / 2.0;

    while (!quit_requested())
    {
        process_events();

        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(A_KEY))
        {
            scale = scale - step;
            if (scale < min_scale)
            {
                scale = min_scale;
            }
        }
        if (key_typed(D_KEY))
        {
            scale = scale + step;
            if (scale > max_scale)
            {
                scale = max_scale;
            }
        }
        if (key_typed(R_KEY))
        {
            scale = 1.0;
        }
        if (key_typed(SPACE_KEY))
        {
            show_outline = !show_outline;
        }

        clear_screen(COLOR_WHITE);

        // I am drawing the sticker centered with scaling applied
        const double x = cx - bitmap_width(sticker) / 2.0;
        const double y = cy - bitmap_height(sticker) / 2.0;
        draw_bitmap(sticker, x, y, option_scale_bmp(scale, scale));

        if (show_outline)
        {
            // I am showing a scaled outline rectangle to make the effect obvious
            const double w = bitmap_width(sticker) * scale;
            const double h = bitmap_height(sticker) * scale;
            draw_rectangle(COLOR_NAVY, cx - w / 2.0, cy - h / 2.0, w, h);
        }

        // UI text on the window
        draw_text("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit", COLOR_NAVY, 16, 16);

        char info[96];
        std::snprintf(info, sizeof(info), "Scale: %.1f×", scale);
        draw_text(info, COLOR_BLACK, 16, 40);

        refresh_screen(60);
    }

    free_bitmap(sticker);
    return 0;
}