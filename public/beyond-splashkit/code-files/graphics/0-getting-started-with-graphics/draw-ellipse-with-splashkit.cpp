#include "splashkit.h"

int main()
{
    open_window("Draw Ellipse", 800, 600);

    clear_screen(COLOR_WHITE);

    // Draw 30 ellipses
    for (int i = 0; i < 30; i++)
    {
        int width = 600 - i * 20;   
        int height = 400 - i * 10;  
        int x = 100 + i * 10;       
        int y = 100 + i * 5;        

        // Draw ellipse based on the current dimensions and position
        draw_ellipse(random_rgb_color(255), x, y, width, height);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
