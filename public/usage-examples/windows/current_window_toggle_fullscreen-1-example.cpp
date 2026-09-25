#include "splashkit.h"

int main()
{
    open_window("Presentation Mode", 800, 450);

    while (!quit_requested())
    {
        process_events();

        // Toggling means the same key can both enter and leave fullscreen
        if (key_typed(F_KEY))
        {
            current_window_toggle_fullscreen();
        }

        // Draw for the new state so the screen shows which mode the window is in
        if (current_window_is_fullscreen())
        {
            clear_screen(COLOR_BLACK);
            draw_text("Fullscreen mode", COLOR_WHITE, "arial", 48, 40, 60);
            draw_text("Press F to leave fullscreen", COLOR_LIGHT_GRAY, "arial", 28, 40, 150);
        }
        else
        {
            clear_screen(COLOR_WHITE);
            draw_text("Windowed mode", COLOR_BLACK, "arial", 48, 40, 60);
            draw_text("Press F to enter fullscreen", COLOR_DARK_GRAY, "arial", 28, 40, 150);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
