#include "splashkit.h"

int main()
{
    open_window("Simple Welcome Screen", 800, 600);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_SKY_BLUE);
        fill_rectangle(COLOR_WHITE, 220, 230, 360, 120);
        draw_text("Welcome to SplashKit!", COLOR_BLACK, 290, 270);
        draw_text("This window was opened using open_window.", COLOR_BLACK, 245, 305);

        refresh_screen(60);
    }

    return 0;
}