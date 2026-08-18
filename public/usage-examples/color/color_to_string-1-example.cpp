#include "splashkit.h"

int main()
{
    open_window("Color To String", 800, 500);

    color shades[] = {
        rgba_color(180, 30, 80, 255),
        rgba_color(40, 140, 220, 255),
        rgba_color(90, 180, 100, 255)
    };

    string names[] = {
        "Rose",
        "Blue",
        "Green"
    };

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);
        draw_text("Color to string examples", COLOR_BLACK, 260, 40);

        for (int i = 0; i < 3; i++)
        {
            string value = color_to_string(shades[i]);

            fill_rectangle(shades[i], 90 + i * 240, 150, 160, 100);
            draw_text(names[i], COLOR_BLACK, 140 + i * 240, 280);
            draw_text(value, COLOR_BLACK, 110 + i * 240, 320);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}