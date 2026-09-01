#include "splashkit.h"

int main()
{
    open_window("Checkbox Example", 700, 500);

    bool show_grid = false;
    bool sound_enabled = true;
    bool dark_background = false;

    rectangle panel_area = rectangle_from(40, 90, 280, 150);
    rectangle positioned_checkbox = rectangle_from(380, 120, 220, 40);

    while (!quit_requested())
    {
        process_events();

        if (dark_background)
        {
            clear_screen(COLOR_DARK_SLATE_GRAY);
        }
        else
        {
            clear_screen(COLOR_WHITE);
        }

        color text_color = dark_background ? COLOR_WHITE : COLOR_BLACK;

        if (show_grid)
        {
            for (int x = 0; x < 700; x += 50)
            {
                draw_line(COLOR_LIGHT_GRAY, x, 0, x, 500);
            }

            for (int y = 0; y < 500; y += 50)
            {
                draw_line(COLOR_LIGHT_GRAY, 0, y, 700, y);
            }
        }

        draw_text(
            "SplashKit Checkbox Example",
            text_color,
            40,
            35
        );

        if (start_panel("Options", panel_area))
        {
            show_grid = checkbox("Show Grid", show_grid);

            sound_enabled = checkbox(
                "Sound",
                "Enabled",
                sound_enabled
            );

            end_panel("Options");
        }

        dark_background = checkbox(
            "Dark Background",
            dark_background,
            positioned_checkbox
        );

        draw_text(
            "Try clicking each checkbox",
            text_color,
            380,
            190
        );

        draw_interface();
        refresh_screen(60);
    }

    return 0;
}