#include "splashkit.h"

int main()
{
    open_window("Draw Ellipse", 800, 600);
    clear_screen();

    // Draw 30 ellipses
    for (int i = 0; i < 30; i++)
    {   
        // Decrease width by 20 every round
        int width = 600 - i * 20;
        // Decrease height by 10 every round
        int height = 400 - i * 10;
        // Increase x position by 10 every round
        int x = 100 + i * 10;
        // Increase y position by 5 every round
        int y = 100 + i * 5;

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw ellipse base on the given data
        draw_ellipse(randomColor, x, y, width, height);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
