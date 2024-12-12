#include "splashkit.h"

int main()
{
    open_window("Draw Ellipse", 800, 600);
    clear_screen();

    for (int i = 0; i < 30; i++)
    {
        int width = 600 - i * 20;
        int height = 400 - i * 10;
        int x = 100 + i * 10;
        int y = 100 + i * 5;

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        draw_ellipse(randomColor, x, y, width, height);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
