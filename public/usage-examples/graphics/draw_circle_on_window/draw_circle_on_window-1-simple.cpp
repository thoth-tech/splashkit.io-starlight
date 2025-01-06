#include "splashkit.h"

int main()
{
    window myWindow = open_window("Draw Circle on Window", 800, 600);
    clear_screen();
    
    for (int i = 0; i < 50; i++)
    {
        // Set random x position to 1 - 800
        double x = rnd(800);

        // Set random y position to 1 - 600
        double y = rnd(600);

        // Set random radius to 1 - 50
        double radius = rnd(50);

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));

        // Draw the circle base on the random data
        draw_circle_on_window(myWindow, randomColor, x, y, radius);
    }
    
    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
