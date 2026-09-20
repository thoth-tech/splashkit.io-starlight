#include "splashkit.h"

int main()
{
    open_window("LED Bit Display", 800, 300);

    // The bits come back as text, one character for each LED
    unsigned int display_value = 178;
    string bits = dec_to_bin(display_value);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Number: " + std::to_string(display_value), COLOR_BLACK, 40, 40);
        draw_text("Binary: " + bits, COLOR_BLACK, 40, 80);

        // A lit LED is a 1 bit and a dark LED is a 0 bit
        int led_x = 80;
        for (char bit : bits)
        {
            if (bit == '1')
            {
                fill_circle(COLOR_YELLOW, led_x, 190, 32);
            }
            else
            {
                fill_circle(COLOR_LIGHT_GRAY, led_x, 190, 32);
            }

            draw_circle(COLOR_BLACK, led_x, 190, 32);
            led_x += 90;
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
