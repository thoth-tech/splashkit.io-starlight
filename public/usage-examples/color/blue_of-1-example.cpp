#include "splashkit.h"

int main()
{
    // Open the window for the usage example
    open_window("Reading the Blue Channel", 800, 400);

    // Three shades of blue with the same red/green/alpha, only blue differs
    color shades[] = {
        rgba_color(80, 80, 30, 255),
        rgba_color(80, 80, 130, 255),
        rgba_color(80, 80, 230, 255)
    };

    string labels[] = {
        "Low Blue",
        "Medium Blue",
        "High Blue"
    };

    while (!quit_requested())
    {
        process_events();

        // Draw the background and instructions
        clear_screen(COLOR_WHITE);
        draw_text("Blue values for these shades", COLOR_BLACK, 240, 40);

        // Draw each shade and use blue_of to read its blue component
        for (int i = 0; i < 3; i++)
        {
            int value = blue_of(shades[i]);

            fill_rectangle(shades[i], 80 + i * 240, 140, 160, 80);
            draw_text(labels[i], COLOR_BLACK, 115 + i * 240, 250);
            draw_text("Blue: " + std::to_string(value), COLOR_BLACK, 115 + i * 240, 290);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
