#include "splashkit.h"

int main()
{
    open_window("Bit Groups to Octal", 800, 360);

    string bits = "101110011";

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        string octal_code = "";

        for (int group = 0; group < 3; group++)
        {
            // Every group of three bits is exactly one octal digit
            string group_bits = bits.substr(group * 3, 3);
            string octal_digit = bin_to_oct(group_bits);
            octal_code += octal_digit;

            double group_x = 80 + group * 240;
            fill_rectangle(COLOR_LIGHT_BLUE, group_x, 120, 160, 150);
            draw_rectangle(COLOR_BLACK, group_x, 120, 160, 150);
            draw_text(group_bits, COLOR_BLACK, group_x + 68, 150);
            draw_text(octal_digit, COLOR_BLUE, group_x + 76, 220);
        }

        draw_text("Binary: " + bits, COLOR_BLACK, 40, 40);
        draw_text("Octal: " + octal_code, COLOR_BLACK, 40, 75);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
