#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Color Red Example", 800, 600);
    
    // Get the red color
    color red_color = color_red();
    
    write_line("Color Red Example");
    write_line("Drawing shapes in red color");
    write_line("Press any key to exit");
    
    while (!window_close_requested("Color Red Example"))
    {
        // Clear the screen to white
        clear_screen(COLOR_WHITE);
        
        // Draw a red circle
        fill_circle(red_color, 200, 200, 100);
        
        // Draw a red rectangle
        fill_rectangle(red_color, 400, 150, 150, 100);
        
        // Draw a red triangle
        fill_triangle(red_color, 600, 300, 700, 200, 650, 400);
        
        // Draw red text
        draw_text("Red Color Example", red_color, 50, 50);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    return 0;
} 