#include "splashkit.h"

int main()
{
    open_window("Interactive Circle", 800, 600);

    double x = 400;
    double y = 300;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        if (key_down(LEFT_KEY)) x -= 5;
        if (key_down(RIGHT_KEY)) x += 5;
        if (key_down(UP_KEY)) y -= 5;
        if (key_down(DOWN_KEY)) y += 5;

        draw_circle(COLOR_BLUE, x, y, 50);

        refresh_screen(60);
    }

    return 0;
}