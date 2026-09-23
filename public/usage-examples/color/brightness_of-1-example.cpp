#include "splashkit.h"

int main()
{
    // Open the window for the usage example
    open_window("Purple Shade Brightness", 800, 400);

    color shades[] = {
        rgba_color(70, 30, 100, 255),
        rgba_color(140, 70, 180, 255),
        rgba_color(210, 170, 240, 255)
    };

    string names[] = {
        "Dark Purple",
        "Medium Purple",
        "Light Purple"
    };

    while (!quit_requested())
    {
        process_events();

        // Draw the background and instructions
        clear_screen(COLOR_WHITE);
        draw_text("Brightness values of purple shades", COLOR_BLACK, 210, 40);

        // Draw each shade and its brightness value
        for (int i = 0; i < 3; i++)
        {
            double value = brightness_of(shades[i]);

            fill_circle(shades[i], 150 + i * 240, 180, 55);
            draw_text(names[i], COLOR_BLACK, 105 + i * 240, 260);
            draw_text("Brightness: " + std::to_string(value), COLOR_BLACK, 75 + i * 240, 300);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
