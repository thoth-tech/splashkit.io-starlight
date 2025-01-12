#include "splashkit.h"

int main()
{
    //Create a window with title Fill rectangle, width 800, height 600.
    open_window("Fill Rectangle", 800, 600);
    clear_screen();

    //draw three rectangles with color green, yellow, and red with different position as (100,200), (300,200), (500,200) with same size.
    fill_rectangle(COLOR_GREEN, 100, 200, 200, 100);
    fill_rectangle(COLOR_YELLOW, 300, 200, 200, 100);
    fill_rectangle(COLOR_RED, 500, 200, 200, 100);
    refresh_screen();
    
    delay(4000);

    close_all_windows();

    return 0;
}