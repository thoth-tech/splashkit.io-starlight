#include "splashkit.h"

int main()
{
    open_window("Color Black", 600, 500);

    clear_screen(color_white());

    // Draw an 8 x 8 checkerboard
    for (int row = 0; row < 8; row++)
    {
        for (int col = 0; col < 8; col++)
        {
            // Fill every second square, leaving the others white
            if ((row + col) % 2 == 0)
            {
                // Function used here ↓
                fill_rectangle(color_black(), 100 + col * 50, 60 + row * 50, 50, 50);
            }
        }
    }

    // color_black is also useful for drawing text on a light background
    draw_text("A checkerboard drawn with color_black", color_black(), 175, 25);

    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}
