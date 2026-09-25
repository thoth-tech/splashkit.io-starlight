#include "splashkit.h"

int main()
{
    open_window("Inset Rectangle Example", 400, 300);

    // The fixed outer rectangle
    rectangle outer_rect = rectangle_from(50, 50, 300, 200);

    double inset_amount = 0;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Increase or decrease the inset amount with the arrow keys
        if (key_down(UP_KEY) && inset_amount < 95)
        {
            inset_amount += 1;
        }
        if (key_down(DOWN_KEY) && inset_amount > 0)
        {
            inset_amount -= 1;
        }

        // Draw the outer rectangle
        draw_rectangle(COLOR_BLACK, outer_rect);

        // Get and draw the inset rectangle
        rectangle inner_rect = inset_rectangle(outer_rect, inset_amount);
        fill_rectangle(COLOR_RED, inner_rect);

        // Display the current inset amount, fixed to the screen
        draw_text("Inset amount: " + to_string((int)inset_amount), COLOR_BLACK, 10, 10, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}