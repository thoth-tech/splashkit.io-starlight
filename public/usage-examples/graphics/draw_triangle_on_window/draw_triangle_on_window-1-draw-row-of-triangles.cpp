#include "splashkit.h"

int main()
{
    window myWindow = open_window("Draw Triangle on Window", 800, 600);
    clear_screen();

    for (int i = 0; i < 20; i++)
    {
        double x = 40 * i;
        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_triangle_on_window(myWindow, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}