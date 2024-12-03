#include "splashkit.h"

int main()
{
    open_window("Draw Rectangle", 800, 600);
    clear_screen();

    for (int i = 0; i < 21; i++)
    {
      
        int x = i * 40 - 40;
        int y = 600 - i * 30;

        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_rectangle(randomColor, x, y, 40, 30);
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}