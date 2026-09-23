#include "splashkit.h"

int main()
{
    open_window("HSB Color", 800, 600);

    double hue = 0.0;
    double saturation = 1.0;
    double brightness = 1.0;

    while (!quit_requested())
    {
        process_events();

        // Use the keyboard to adjust the HSB values.
        if (key_down(LEFT_KEY))
        {
            hue -= 0.005;
        }

        if (key_down(RIGHT_KEY))
        {
            hue += 0.005;
        }

        if (key_down(DOWN_KEY))
        {
            saturation -= 0.005;
        }

        if (key_down(UP_KEY))
        {
            saturation += 0.005;
        }

        if (key_down(S_KEY))
        {
            brightness -= 0.005;
        }

        if (key_down(W_KEY))
        {
            brightness += 0.005;
        }

        // Keep each HSB value between 0 and 1.
        if (hue < 0.0)
        {
            hue = 0.0;
        }

        if (hue > 1.0)
        {
            hue = 1.0;
        }

        if (saturation < 0.0)
        {
            saturation = 0.0;
        }

        if (saturation > 1.0)
        {
            saturation = 1.0;
        }

        if (brightness < 0.0)
        {
            brightness = 0.0;
        }

        if (brightness > 1.0)
        {
            brightness = 1.0;
        }

        // Create a color from the current HSB values.
        color selected_color = hsb_color(
            hue,
            saturation,
            brightness
        );

        // Draw the selected color and its current values.
        clear_screen(COLOR_BLACK);

        fill_rectangle(
            selected_color,
            250,
            120,
            300,
            260
        );

        draw_text(
            "Hue: " + std::to_string(hue),
            COLOR_WHITE,
            40,
            430
        );

        draw_text(
            "Saturation: " + std::to_string(saturation),
            COLOR_WHITE,
            40,
            460
        );

        draw_text(
            "Brightness: " + std::to_string(brightness),
            COLOR_WHITE,
            40,
            490
        );

        draw_text(
            "Left/Right: Hue   Up/Down: Saturation   W/S: Brightness",
            COLOR_WHITE,
            40,
            530
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}