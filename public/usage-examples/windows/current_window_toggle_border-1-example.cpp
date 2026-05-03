#include "splashkit.h"
#include <string>

using namespace std;

int main()
{
    open_window("Press B to Toggle Border", 700, 250);

    while (!quit_requested())
    {
        process_events();

        if (key_typed(B_KEY))
        {
            current_window_toggle_border();
        }

        bool has_border = current_window_has_border();
        string border_state = has_border ? "On" : "Off";

        clear_screen(COLOR_WHITE);

        draw_text("Press B to toggle border", COLOR_BLACK, 20, 20);
        draw_text("Border: " + border_state, COLOR_BLUE, 20, 80);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}