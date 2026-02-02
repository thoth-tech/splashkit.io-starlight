#include "splashkit.h"

int main()
{
    window win = open_window("Window Mover", 300, 300);

    while (!quit_requested())
    {
        // Get user inputs
        process_events();

        clear_screen(COLOR_WHITE);

        // Get position of the window
        int current_x = window_x(win);
        int current_y = window_y(win);

        // Move window buttons
        if (button("NW", rectangle_from(50, 50, 40, 40)))
        {
            move_window_to(win, current_x - 10, current_y - 10);
        }

        if (button("N", rectangle_from(130, 50, 40, 40)))
        {
            move_window_to(win, current_x, current_y - 10);
        }

        if (button("NE", rectangle_from(210, 50, 40, 40)))
        {
            move_window_to(win, current_x + 10, current_y - 10);
        }

        if (button("W", rectangle_from(50, 130, 40, 40)))
        {
            move_window_to(win, current_x - 10, current_y);
        }

        if (button("E", rectangle_from(210, 130, 40, 40)))
        {
            move_window_to(win, current_x + 10, current_y);
        }

        if (button("SW", rectangle_from(50, 210, 40, 40)))
        {
            move_window_to(win, current_x - 10, current_y + 10);
        }

        if (button("S", rectangle_from(130, 210, 40, 40)))
        {
            move_window_to(win, current_x, current_y + 10);
        }

        if (button("SE", rectangle_from(210, 210, 40, 40)))
        {
            move_window_to(win, current_x + 10, current_y + 10);
        }

        draw_interface();
        refresh_screen();
    }

    // close all open windows
    close_all_windows();
    return 0;
}