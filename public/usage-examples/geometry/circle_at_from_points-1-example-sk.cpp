#include "splashkit.h"

int main()
{
    open_window("Flag of Japan", 600, 400);
    
    // Create a circle at (300, 200) with radius 120
    circle myCircle = circle_at(300, 200, 120);
    
    while (!window_close_requested("Flag of Japan")) {
        process_events();
        clear_screen(COLOR_WHITE);
        
        // Draw the circle
        fill_circle(COLOR_DARK_RED, myCircle);
        
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
