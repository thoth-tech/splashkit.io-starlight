#include "splashkit.h"

int main()
{
    open_window("Simple Red Triangle", 400, 300);

    while (not quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);
        fill_triangle(COLOR_RED, 100, 100, 200, 100, 150, 200);
        refresh_screen(60);
    }

    return 0;
}
