#include "splashkit.h"

int main() 
{
    
open_window("Option Flip X", 600, 600);

    
bitmap bmp = load_bitmap("Player", "character.png");

// Draw the original bitmap image at position (100, 300)
draw_bitmap(bmp, 100, 300);

// Draw the bitmap image flipped horizontally at position (500, 300)
draw_bitmap(bmp, 500, 300, option_flip_x());

    
refresh_screen();

    
delay(5000);

    
close_all_windows();

return 0;
}
