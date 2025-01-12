#include "splashkit.h"

int main()
{
    window window = open_window("Draw Triangle on Window", 800, 600);
    clear_screen();

    for (int i = 0; i < 20; i++)
    {
        // Set the x position for triangles increase by 40 * i every round
        double x = 40 * i;

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw the triangles by increasing x position
        draw_triangle_on_window(window, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}