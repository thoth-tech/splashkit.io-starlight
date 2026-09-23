#include "splashkit.h"

int main()
{
    open_window("Interface Element Contrast", 700, 420);

    color element_color = rgb_color(70, 160, 220);
    float contrast = 0.0f;

    while (!quit_requested())
    {
        process_events();

        // Change the interface contrast using number keys
        if (key_typed(NUM_1_KEY))
        {
            contrast = 0.0f;
        }

        if (key_typed(NUM_2_KEY))
        {
            contrast = 1.0f;
        }

        // Apply the selected color and contrast to the interface
        set_interface_element_color(element_color, contrast);

        clear_screen(color_white());

        draw_text(
            "Press 1 for minimum contrast or 2 for maximum contrast",
            color_black(),
            90,
            80
        );

        draw_text(
            "Current contrast: " + std::to_string(contrast),
            color_black(),
            240,
            130
        );

        button(
            "Interface Button",
            rectangle_from(230, 200, 240, 60)
        );

        draw_interface();
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}