#include "splashkit.h"

int main()
{
    open_window("Fullscreen Checker", 800, 450);

    while (!quit_requested())
    {
        process_events();

        // Give the player a way to change the state that we are about to check
        if (key_typed(F_KEY))
        {
            current_window_toggle_fullscreen();
        }

        clear_screen(COLOR_WHITE);

        // Check every frame so the text always matches what the window is doing
        bool is_fullscreen = current_window_is_fullscreen();

        if (is_fullscreen)
        {
            draw_text("Fullscreen: true", COLOR_BLACK, "arial", 48, 40, 60);
        }
        else
        {
            draw_text("Fullscreen: false", COLOR_BLACK, "arial", 48, 40, 60);
        }

        draw_text("Press F to switch", COLOR_DARK_GRAY, "arial", 28, 40, 150);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
