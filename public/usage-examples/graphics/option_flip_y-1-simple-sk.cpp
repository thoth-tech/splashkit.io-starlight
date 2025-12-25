#include "splashkit.h"

int main() 
{
open_window("Option Flip Y", 600, 600);

bitmap bmp = load_bitmap("Landscape", "landscape.png");

// Draw the original bitmap image at position (100, 300)
draw_bitmap(bmp, 100, 300);

// Draw the bitmap image flipped horizontally at position (400, 300)
draw_bitmap(bmp, 300, 100, option_flip_y());

refresh_screen();

delay(5000);

close_all_windows();

return 0;
}
