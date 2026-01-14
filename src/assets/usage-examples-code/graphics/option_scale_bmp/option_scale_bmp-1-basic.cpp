// I am scaling a bitmap at draw time with option_scale_bmp.
// I am pressing A to make smaller; I am pressing D to make bigger; I am pressing R to reset;
// I am pressing SPACE to toggle outline; I am pressing ESC to quit.

#include "splashkit.h"
#include <cstdio>

static bitmap make_sticker_bitmap()
{
    // I am creating a small procedural bitmap so no external file is needed.
    const int stickerWidth = 128;
    const int stickerHeight = 128;
    bitmap bmp = create_bitmap("sticker", stickerWidth, stickerHeight);
    clear_bitmap(bmp, rgba_color(255, 255, 255, 0)); // I am making the background transparent.

    // I am drawing a light grid to show scale changes.
    for (int y = 0; y < stickerHeight; y += 16)
    {
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), 0, y, stickerWidth, y);
    }
    for (int x = 0; x < stickerWidth; x += 16)
    {
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), x, 0, x, stickerHeight);
    }

    // I am drawing a circle and a border so the sticker is easy to see.
    fill_circle_on_bitmap(bmp, rgb_color(33, 150, 243), stickerWidth / 2, stickerHeight / 2, 36);
    draw_circle_on_bitmap(bmp, COLOR_BLACK, stickerWidth / 2, stickerHeight / 2, 36);
    draw_rectangle_on_bitmap(bmp, COLOR_BLACK, 1, 1, stickerWidth - 2, stickerHeight - 2);

    return bmp;
}

int main()
{
    // I am opening the window with a short title; I am drawing instructions inside the window.
    open_window("Option Scale Bmp - live", 800, 480);

    // I am building the sticker once and I am reusing it each frame.
    bitmap stickerBitmap = make_sticker_bitmap();

    // I am tracking the current scale and the valid range.
    double currentScale = 1.0;
    const double scaleStep = 0.1;
    const double minScale = 0.2;
    const double maxScale = 3.0;

    // I am toggling an outline so the scaled bounds are obvious.
    bool showOutline = true;

    // I am centering my drawing around the window middle.
    const double centerX = 800 / 2.0;
    const double centerY = 480 / 2.0;

    while (!quit_requested())
    {
        process_events();

        // I am handling the controls.
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(A_KEY))
        {
            currentScale = currentScale - scaleStep;
            if (currentScale < minScale)
            {
                currentScale = minScale;
            }
        }
        if (key_typed(D_KEY))
        {
            currentScale = currentScale + scaleStep;
            if (currentScale > maxScale)
            {
                currentScale = maxScale;
            }
        }
        if (key_typed(R_KEY))
        {
            currentScale = 1.0;
        }
        if (key_typed(SPACE_KEY))
        {
            showOutline = !showOutline;
        }

        // I am clearing the frame to white.
        clear_screen(COLOR_WHITE);

        // I am drawing the sticker centered with the current scale applied.
        const double drawX = centerX - bitmap_width(stickerBitmap) / 2.0;
        const double drawY = centerY - bitmap_height(stickerBitmap) / 2.0;
        draw_bitmap(stickerBitmap, drawX, drawY, option_scale_bmp(currentScale, currentScale));

        // I am drawing an outline that matches the scaled size.
        if (showOutline)
        {
            const double outlineWidth  = bitmap_width(stickerBitmap)  * currentScale;
            const double outlineHeight = bitmap_height(stickerBitmap) * currentScale;
            draw_rectangle(COLOR_NAVY,
                           centerX - outlineWidth / 2.0,
                           centerY - outlineHeight / 2.0,
                           outlineWidth,
                           outlineHeight);
        }

        // I am drawing the UI hints.
        draw_text("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
                  rgb_color(0, 0, 128), 16, 16);

        char info[96];
        std::snprintf(info, sizeof(info), "Scale: %.1f x", currentScale);
        draw_text(info, rgb_color(0, 0, 0), 16, 40);

        refresh_screen(60);
    }

    // I am freeing the bitmap before I quit.
    free_bitmap(stickerBitmap);
    return 0;
}