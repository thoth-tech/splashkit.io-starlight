#include "splashkit.h"

int main()
{
    window myWindow = open_window("Draw Circle on Window", 800, 600);
    clear_screen();
    
    for (int i = 0; i < 50; i++)
    {
        double x = rand() % 800;
        double y = rand() % 600;
        double radius = rand() % 50;

        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_circle_on_window(myWindow, randomColor, x, y, radius);
    }
    
    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
