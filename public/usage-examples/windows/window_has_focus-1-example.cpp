#include "splashkit.h"

int main()
{
    open_window("Window Has Focus", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // Check whether the current window has focus
        bool has_focus = window_has_focus(current_window());

        clear_screen(COLOR_WHITE);

        // Show the current focus state on screen
        draw_text("Click on or away from the window to change focus.", COLOR_BLACK, 120, 220);

        if (has_focus)
        {
            draw_text("Window has focus", COLOR_GREEN, 280, 280);
        }
        else
        {
            draw_text("Window does not have focus", COLOR_RED, 240, 280);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}