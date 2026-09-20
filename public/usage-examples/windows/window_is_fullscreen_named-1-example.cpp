#include "splashkit.h"

int main()
{
    // Keep the caption in one variable so the window and the lookups can never disagree
    string preview_caption = "Preview";

    window dashboard_window = open_window("Dashboard", 480, 280);
    window preview_window = open_window(preview_caption, 480, 280);

    // Place the windows side by side so both stay visible
    move_window_to(dashboard_window, 60, 100);
    move_window_to(preview_window, 580, 100);

    while (!quit_requested())
    {
        process_events();

        // The F key sends the preview window in and out of fullscreen
        if (key_typed(F_KEY))
        {
            window_toggle_fullscreen(preview_caption);
        }

        // Look the window up by its caption, so no window handle is needed here
        bool preview_is_fullscreen = window_is_fullscreen(preview_caption);

        // The whole dashboard acts as a status light
        if (preview_is_fullscreen)
        {
            clear_window(dashboard_window, COLOR_LIGHT_GREEN);
            draw_text_on_window(dashboard_window, "Preview is fullscreen", COLOR_BLACK, "arial", 30, 20, 60);
        }
        else
        {
            clear_window(dashboard_window, COLOR_LIGHT_GRAY);
            draw_text_on_window(dashboard_window, "Preview is windowed", COLOR_BLACK, "arial", 30, 20, 60);
        }

        draw_text_on_window(dashboard_window, "Press F to toggle the preview", COLOR_DARK_GRAY, "arial", 20, 20, 140);
        refresh_window(dashboard_window);

        clear_window(preview_window, COLOR_LIGHT_BLUE);
        draw_text_on_window(preview_window, "Preview", COLOR_BLACK, "arial", 40, 20, 40);

        // The preview shows the same answer, because the dashboard is hidden while it fills the screen
        if (preview_is_fullscreen)
        {
            draw_text_on_window(preview_window, "Fullscreen: true", COLOR_BLACK, "arial", 30, 20, 120);
        }
        else
        {
            draw_text_on_window(preview_window, "Fullscreen: false", COLOR_BLACK, "arial", 30, 20, 120);
        }

        draw_text_on_window(preview_window, "Press F to toggle", COLOR_DARK_GRAY, "arial", 20, 20, 190);
        refresh_window(preview_window);
    }

    close_all_windows();
    return 0;
}
