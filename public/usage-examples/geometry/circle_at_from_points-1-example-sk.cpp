#include "splashkit.h"


int main() {
    open_window("Circle At Example", 800, 600);
    
    // Create a circle at (400, 300) with radius 100
    circle myCircle = circle_at(400, 300, 100);
    
    while (!window_close_requested("Circle At Example")) {
        process_events();
        clear_screen(COLOR_WHITE);
        
        // Draw the circle
        fill_circle(COLOR_BLUE, myCircle);
        
        refresh_screen(60);
    }
    
    return 0;
}