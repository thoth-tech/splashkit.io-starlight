#include "splashkit.h"

int main()
{
    open_window("Text Example", 800, 600);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Hello SplashKit!", COLOR_BLACK, 300, 250);

        refresh_screen();
    }

    return 0;
}