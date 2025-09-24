#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Log Example", 800, 600);
    
    write_line("Log Example");
    write_line("Check the console/terminal for logged messages");
    write_line("Press any key to exit");
    
    // Log different types of messages
    log("INFO", "Application started successfully");
    log("DEBUG", "Debug information: Window opened at 800x600");
    log("WARNING", "This is a warning message");
    log("ERROR", "This is an error message");
    
    // Log with different message types
    log("INFO", "User clicked the start button");
    log("DEBUG", "Button position: x=100, y=200");
    log("INFO", "Game score: 1500 points");
    log("WARNING", "Low memory warning: 10MB remaining");
    
    while (!window_close_requested("Log Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Display logging information
        draw_text("Log Example - Check Console/Terminal", COLOR_BLACK, 50, 50);
        draw_text("The following messages have been logged:", COLOR_BLACK, 50, 100);
        
        draw_text("INFO: Application started successfully", COLOR_BLUE, 70, 150);
        draw_text("DEBUG: Debug information: Window opened at 800x600", COLOR_GREEN, 70, 180);
        draw_text("WARNING: This is a warning message", COLOR_ORANGE, 70, 210);
        draw_text("ERROR: This is an error message", COLOR_RED, 70, 240);
        draw_text("INFO: User clicked the start button", COLOR_BLUE, 70, 270);
        draw_text("DEBUG: Button position: x=100, y=200", COLOR_GREEN, 70, 300);
        draw_text("INFO: Game score: 1500 points", COLOR_BLUE, 70, 330);
        draw_text("WARNING: Low memory warning: 10MB remaining", COLOR_ORANGE, 70, 360);
        
        // Instructions
        draw_text("Look at your console/terminal to see the actual log messages", COLOR_BLACK, 50, 450);
        draw_text("Press any key to exit", COLOR_BLACK, 50, 500);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    // Log application exit
    log("INFO", "Application shutting down");
    
    return 0;
} 