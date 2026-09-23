#include "splashkit.h"

int main()
{
    open_window("Interface Accent Contrast", 700, 420);

    color accent_color = rgb_color(230, 80, 120);
    float contrast = 0.0f;

    while (!quit_requested())
    {
        process_events();

        // Change the interface accent contrast using number keys
        if (key_typed(NUM_1_KEY))
        {
            contrast = 0.0f;
        }

        if (key_typed(NUM_2_KEY))
        {
            contrast = 1.0f;
        }

        // Apply the selected accent color and contrast to the interface
        set_interface_accent_color(accent_color, contrast);

        clear_screen(color_white());

        draw_text(
            "Press 1 for minimum accent or 2 for maximum accent",
            color_black(),
            90,
            70
        );

        draw_text(
            "Hover over the button to see the accent effect",
            color_black(),
            120,
            110
        );

        draw_text(
            "Current contrast: " + std::to_string(contrast),
            color_black(),
            240,
            150
        );

        button(
            "Hover Over Me",
            rectangle_from(230, 220, 240, 60)
        );

        draw_interface();
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}