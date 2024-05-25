#include "splashkit.h"

int main()
{
    window my_window = open_window("My Window", 800, 600);

    while (!window_close_requested(my_window))
    {
        process_events();
        clear_screen(COLOR_WHITE);
        draw_text("Hello, SplashKit!", COLOR_BLACK, 20, 20);
        refresh_screen();
    }

    close_window(my_window);

    return 0;
}
