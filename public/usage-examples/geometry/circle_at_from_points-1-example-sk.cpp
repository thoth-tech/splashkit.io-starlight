#include "splashkit.h"

int main()
{
    open_window("Blue Circle at the centre", 800, 600);
    
    // Create a circle at (400, 300) with radius 100
    circle myCircle = circle_at(400, 300, 100);
    
    while (!window_close_requested("Blue Circle at the centre")) {
        process_events();
        clear_screen(COLOR_WHITE);
        
        // Draw the circle
        fill_circle(COLOR_BLUE, myCircle);
        
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
