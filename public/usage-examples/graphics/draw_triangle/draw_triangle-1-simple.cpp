#include "splashkit.h"

int main()
{
    open_window("Draw Triangle", 800, 600);
    clear_screen();

    for (int i = 0; i < 10; i++)
    {
        // Random point 1 for the trangle (x1,y1)
        int x1 = rnd(800);
        int y1 = rnd(600);

        // Random point 2 for the trangle (x2,y2)
        int x2 = rnd(800);
        int y2 = rnd(600);

        // Random point 3 for the trangle (x3,y3)
        int x3 = rnd(800);
        int y3 = rnd(600);

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw trangle base on the three random points
        draw_triangle(randomColor, x1, y1, x2, y2, x3, y3);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}