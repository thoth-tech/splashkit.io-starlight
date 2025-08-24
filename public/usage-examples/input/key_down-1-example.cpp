#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Key Down Example", 800, 600);
    
    write_line("Key Down Example");
    write_line("Press and hold keys to see their state");
    write_line("Press ESC to exit");
    
    while (!window_close_requested("Key Down Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Check various keys and display their state
        if (key_down(SPACE_KEY))
        {
            fill_circle(COLOR_RED, 200, 200, 50);
            draw_text("SPACE - PRESSED", COLOR_RED, 50, 50);
        }
        else
        {
            draw_circle(COLOR_GRAY, 200, 200, 50);
            draw_text("SPACE - Released", COLOR_GRAY, 50, 50);
        }
        
        if (key_down(LEFT_KEY))
        {
            fill_circle(COLOR_BLUE, 400, 200, 50);
            draw_text("LEFT - PRESSED", COLOR_BLUE, 50, 100);
        }
        else
        {
            draw_circle(COLOR_GRAY, 400, 200, 50);
            draw_text("LEFT - Released", COLOR_GRAY, 50, 100);
        }
        
        if (key_down(RIGHT_KEY))
        {
            fill_circle(COLOR_GREEN, 600, 200, 50);
            draw_text("RIGHT - PRESSED", COLOR_GREEN, 50, 150);
        }
        else
        {
            draw_circle(COLOR_GRAY, 600, 200, 50);
            draw_text("RIGHT - Released", COLOR_GRAY, 50, 150);
        }
        
        if (key_down(UP_KEY))
        {
            fill_circle(COLOR_ORANGE, 300, 350, 50);
            draw_text("UP - PRESSED", COLOR_ORANGE, 50, 200);
        }
        else
        {
            draw_circle(COLOR_GRAY, 300, 350, 50);
            draw_text("UP - Released", COLOR_GRAY, 50, 200);
        }
        
        if (key_down(DOWN_KEY))
        {
            fill_circle(COLOR_PURPLE, 500, 350, 50);
            draw_text("DOWN - PRESSED", COLOR_PURPLE, 50, 250);
        }
        else
        {
            draw_circle(COLOR_GRAY, 500, 350, 50);
            draw_text("DOWN - Released", COLOR_GRAY, 50, 250);
        }
        
        // Instructions
        draw_text("Hold down arrow keys and space to see changes", COLOR_BLACK, 50, 500);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    return 0;
} 