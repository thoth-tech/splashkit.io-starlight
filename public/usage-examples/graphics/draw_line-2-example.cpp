#include "splashkit.h"

int main()
{
    open_window("Draw Line Example", 800, 600);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_line(COLOR_RED, 100, 100, 700, 500);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}