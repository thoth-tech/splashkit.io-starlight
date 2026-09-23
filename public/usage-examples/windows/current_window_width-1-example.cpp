#include "splashkit.h"
#include <string>

int main()
{
    open_window("Current Window Width", 800, 600);

    while (!quit_requested())
    {
        process_events();

        int window_width = current_window_width();

        clear_screen(COLOR_WHITE);

        draw_text("Current window width:", COLOR_BLACK, 220, 220);
        draw_text(std::to_string(window_width) + " pixels", COLOR_BLUE, 260, 270);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}