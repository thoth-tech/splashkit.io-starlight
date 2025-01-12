#include "splashkit.h"

int main()
{
    open_window("Draw Rectangle", 800, 600);
    clear_screen();

    for (int i = 0; i < 21; i++)
    {
        // Increase x position by 40 every round
        int x = i * 40 - 40;

        // Decrease y position by 30 every round
        int y = 600 - i * 30;

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw rectangle base on the x, y position with width 40 and height 30
        draw_rectangle(randomColor, x, y, 40, 30);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}