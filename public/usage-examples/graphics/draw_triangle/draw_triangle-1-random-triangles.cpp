#include "splashkit.h"

int main()
{
    open_window("Draw Triangle", 800, 600);
    clear_screen();

    for (int i = 0; i < 10; i++)
    {
        int x1 = rand()% 800;
        int y1 = rand()% 600;
        int x2 = rand()% 800;
        int y2 = rand()% 600;
        int x3 = rand()% 800;
        int y3 = rand()% 600;

        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_triangle(randomColor, x1, y1, x2, y2, x3, y3);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}