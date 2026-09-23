#include "splashkit.h"

int main()
{
    open_window("Bitmap Layer Studio", 960, 540);

    // Scene setup: open window and load four bitmap layers.
    bitmap background_layer = load_bitmap("background_layer", "layer_background.png");
    bitmap mid_layer = load_bitmap("mid_layer", "layer_midground.png");
    bitmap props_layer = load_bitmap("props_layer", "layer_props.png");
    bitmap foreground_layer = load_bitmap("foreground_layer", "layer_foreground.png");

    const double alpha = 0.45;
    const int bg_red = 48;
    const int bg_green = 88;
    const int bg_blue = 128;
    const int fg_red = 250;
    const int fg_green = 216;
    const int fg_blue = 126;

    // Formula layer: C_out = alpha * C_fg + (1 - alpha) * C_bg.
    int out_red = static_cast<int>(alpha * fg_red + (1.0 - alpha) * bg_red);
    int out_green = static_cast<int>(alpha * fg_green + (1.0 - alpha) * bg_green);
    int out_blue = static_cast<int>(alpha * fg_blue + (1.0 - alpha) * bg_blue);
    color blend_guide = rgba_color(out_red, out_green, out_blue, 255);
    color overlay_guide = rgba_color(fg_red, fg_green, fg_blue, static_cast<int>(alpha * 255));

    while (!quit_requested())
    {
        process_events();
        clear_screen();

        // Layer pipeline: draw bitmaps back-to-front for stable compositing.
        draw_bitmap(background_layer, 0, 0);
        draw_bitmap(mid_layer, 0, 0);
        draw_bitmap(props_layer, 0, 0);
        draw_bitmap(foreground_layer, 0, 0);

        // Visual pass: draw depth guides and decorative perspective lines.
        draw_line(blend_guide, 0, 370, 960, 370);
        draw_line(overlay_guide, 480, 120, 180, 520);
        draw_line(overlay_guide, 480, 120, 780, 520);
        draw_line(blend_guide, 120, 500, 840, 500);

        refresh_screen(60);
    }

    free_all_bitmaps();
    close_all_windows();

    return 0;
}
