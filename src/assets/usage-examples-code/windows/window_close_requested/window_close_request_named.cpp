#include "splashkit.h"

int main()
{
    open_window("My Window", 800, 600);

    while (!window_close_requested("My Window"))
    {
        process_events();
        clear_screen(COLOR_WHITE);
        draw_text("Hello, SplashKit!", COLOR_BLACK, 20, 20);
        refresh_screen();
    }

    return 0;
}
