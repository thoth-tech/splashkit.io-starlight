#include "splashkit.h"

using namespace splashkit;

int main()
{
    open_window("Circle Animation", 800, 600);

    double x = 0;

    while (!window_close_requested("Circle Animation"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_circle(COLOR_RED, x, 300, 50);

        x += 2;
        if (x > 800) x = 0;

        refresh_screen(60);
    }

    return 0;
}