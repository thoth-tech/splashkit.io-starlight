#include "splashkit.h"

int main()
{
    open_window("Octal Value Bars", 800, 360);

    string octal_values[] = {"7", "17", "377", "777"};
    int value_count = 4;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Each bar is as long as the decimal value of its octal number.", COLOR_BLACK, 40, 30);

        for (int row = 0; row < value_count; row++)
        {
            // The result is a number, so it is turned back into text to draw it
            unsigned int decimal_value = oct_to_dec(octal_values[row]);
            double row_y = 90 + row * 60;

            draw_text("Octal " + octal_values[row], COLOR_BLACK, 40, row_y + 8);
            fill_rectangle(COLOR_BLUE, 200, row_y, decimal_value, 30);
            draw_text(std::to_string(decimal_value), COLOR_BLACK, 210 + decimal_value, row_y + 8);
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
