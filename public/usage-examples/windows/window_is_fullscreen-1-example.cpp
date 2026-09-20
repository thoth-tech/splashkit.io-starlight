#include "splashkit.h"

void draw_window_status(window wnd, const string &name)
{
    // Ask this specific window, using its handle, whether it is fullscreen
    bool is_fullscreen = window_is_fullscreen(wnd);

    clear_window(wnd, COLOR_WHITE);
    draw_text_on_window(wnd, name, COLOR_BLACK, "arial", 40, 20, 30);

    if (is_fullscreen)
    {
        draw_text_on_window(wnd, "Fullscreen: true", COLOR_BLACK, "arial", 30, 20, 100);
    }
    else
    {
        draw_text_on_window(wnd, "Fullscreen: false", COLOR_BLACK, "arial", 30, 20, 100);
    }

    draw_text_on_window(wnd, "Press L or R to toggle a window", COLOR_DARK_GRAY, "arial", 20, 20, 170);
    refresh_window(wnd);
}

int main()
{
    window left_window = open_window("Left Window", 480, 280);
    window right_window = open_window("Right Window", 480, 280);

    // Place the windows side by side so both stay visible
    move_window_to(left_window, 60, 100);
    move_window_to(right_window, 580, 100);

    while (!quit_requested())
    {
        process_events();

        // Each key sends one window in or out of fullscreen
        if (key_typed(L_KEY))
        {
            window_toggle_fullscreen(left_window);
        }

        if (key_typed(R_KEY))
        {
            window_toggle_fullscreen(right_window);
        }

        // Every window reports its own state, so the text stays visible while it fills the screen
        draw_window_status(left_window, "Left Window");
        draw_window_status(right_window, "Right Window");
    }

    close_all_windows();
    return 0;
}
