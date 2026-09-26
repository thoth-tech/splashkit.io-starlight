#include "splashkit.h"

int main()
{
    open_window("Screen Rectangle", 640, 480);

    rectangle screen = screen_rectangle();

    clear_screen(COLOR_WHITE);

    fill_rectangle(COLOR_LIGHT_BLUE, screen);
    draw_rectangle(COLOR_DARK_BLUE, screen);

    draw_text(
        "screen_rectangle() represents the current window area",
        COLOR_BLACK,
        30,
        40
    );

    draw_text(
        "Window size: 640 x 480",
        COLOR_BLACK,
        30,
        75
    );

    refresh_screen();
    delay(4000);

    close_all_windows();

    return 0;
}
