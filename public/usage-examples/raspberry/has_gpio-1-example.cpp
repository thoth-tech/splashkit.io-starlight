#include "splashkit.h"

int main()
{
    // Open a window
    open_window("GPIO Check Example", 800, 600);
    
    write_line("GPIO Check Example");
    write_line("Checking GPIO availability");
    write_line("Press any key to exit");
    
    // Check if GPIO is available
    bool gpio_available = has_gpio();
    
    while (!window_close_requested("GPIO Check Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Display GPIO information
        draw_text("GPIO Check Example", COLOR_BLACK, 50, 50);
        draw_text("Raspberry Pi GPIO Availability", COLOR_BLACK, 50, 100);
        
        if (gpio_available)
        {
            draw_text("GPIO Status: AVAILABLE", COLOR_GREEN, 50, 150);
            draw_text("GPIO is ready for use on this system", COLOR_GREEN, 70, 200);
            draw_text("You can control GPIO pins for hardware projects", COLOR_GREEN, 70, 230);
        }
        else
        {
            draw_text("GPIO Status: NOT AVAILABLE", COLOR_RED, 50, 150);
            draw_text("GPIO is not available on this system", COLOR_RED, 70, 200);
            draw_text("This is normal on non-Raspberry Pi systems", COLOR_RED, 70, 230);
        }
        
        // Additional information
        draw_text("GPIO (General Purpose Input/Output) allows you to:", COLOR_BLACK, 50, 300);
        draw_text("- Control LED lights", COLOR_BLUE, 70, 330);
        draw_text("- Read button presses", COLOR_BLUE, 70, 360);
        draw_text("- Control motors and servos", COLOR_BLUE, 70, 390);
        draw_text("- Interface with sensors", COLOR_BLUE, 70, 420);
        
        // Instructions
        draw_text("This example checks if GPIO hardware is available", COLOR_BLACK, 50, 500);
        draw_text("Press any key to exit", COLOR_BLACK, 50, 530);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    return 0;
} 