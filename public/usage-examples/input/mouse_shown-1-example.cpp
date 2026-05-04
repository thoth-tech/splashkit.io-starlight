#include "splashkit.h"
#include <string>

int main()
{
    open_window("Mouse Shown", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // Press S to show the mouse, H to hide it
        if (key_typed(S_KEY))
            show_mouse();

        if (key_typed(H_KEY))
            hide_mouse();

        // mouse_shown returns true if the mouse cursor is currently visible
        std::string status;
        if (mouse_shown())
            status = "Mouse is visible";
        else
            status = "Mouse is hidden";

        clear_screen(COLOR_WHITE);
        draw_text("Press S to show the mouse, H to hide it", COLOR_BLACK, "Arial", 18, 170, 250);
        draw_text(status, COLOR_BLUE, "Arial", 24, 170, 290);
        refresh_screen(60);
    }

    // Always show the mouse again before closing
    show_mouse();
    close_all_windows();
    return 0;
}
