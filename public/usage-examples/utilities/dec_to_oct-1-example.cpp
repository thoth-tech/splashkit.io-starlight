#include "splashkit.h"

int main()
{
    open_window("Octal Receipt Codes", 700, 360);

    // Each order number is printed on its receipt as a short octal code
    unsigned int order_numbers[] = {8, 64, 500, 4095};
    int order_count = 4;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Order number", COLOR_BLACK, 60, 40);
        draw_text("Receipt code (octal)", COLOR_BLACK, 300, 40);
        draw_line(COLOR_BLACK, 40, 70, 660, 70);

        for (int row = 0; row < order_count; row++)
        {
            string receipt_code = dec_to_oct(order_numbers[row]);
            double row_y = 100 + row * 50;

            draw_text(std::to_string(order_numbers[row]), COLOR_BLACK, 60, row_y);
            draw_text(receipt_code, COLOR_BLUE, 300, row_y);
        }

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
