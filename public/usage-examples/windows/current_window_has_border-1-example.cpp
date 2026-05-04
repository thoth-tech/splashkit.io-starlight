#include "splashkit.h"

int main()
{
    open_window("Current Window Has Border", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // Press B to toggle the current window border
        if (key_typed(B_KEY))
        {
            current_window_toggle_border();
        }

        // Check whether the current window has a border
        bool has_border = current_window_has_border();

        clear_screen(COLOR_WHITE);

        // Show the current border state on screen
        draw_text("Press B to toggle the window border.", COLOR_BLACK, 170, 220);

        if (has_border)
        {
            draw_text("Current window has a border", COLOR_GREEN, 210, 280);
        }
        else
        {
            draw_text("Current window does not have a border", COLOR_RED, 150, 280);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}