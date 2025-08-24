#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Point At Example", 800, 600);
    
    // Create various points using point_at function
    point_2d center = point_at(400, 300);
    point_2d top_left = point_at(100, 100);
    point_2d top_right = point_at(700, 100);
    point_2d bottom_left = point_at(100, 500);
    point_2d bottom_right = point_at(700, 500);
    
    write_line("Point At Example");
    write_line("Creating and drawing points");
    write_line("Press any key to exit");
    
    while (!window_close_requested("Point At Example"))
    {
        // Clear the screen
        clear_screen(COLOR_WHITE);
        
        // Draw the center point
        fill_circle(COLOR_RED, center, 10);
        draw_text("Center", COLOR_BLACK, center.x + 15, center.y - 10);
        
        // Draw corner points
        fill_circle(COLOR_BLUE, top_left, 8);
        draw_text("Top Left", COLOR_BLACK, top_left.x + 15, top_left.y - 10);
        
        fill_circle(COLOR_GREEN, top_right, 8);
        draw_text("Top Right", COLOR_BLACK, top_right.x - 60, top_right.y - 10);
        
        fill_circle(COLOR_ORANGE, bottom_left, 8);
        draw_text("Bottom Left", COLOR_BLACK, bottom_left.x + 15, bottom_left.y + 15);
        
        fill_circle(COLOR_PURPLE, bottom_right, 8);
        draw_text("Bottom Right", COLOR_BLACK, bottom_right.x - 70, bottom_right.y + 15);
        
        // Draw lines connecting points
        draw_line(COLOR_GRAY, top_left, top_right);
        draw_line(COLOR_GRAY, top_right, bottom_right);
        draw_line(COLOR_GRAY, bottom_right, bottom_left);
        draw_line(COLOR_GRAY, bottom_left, top_left);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    return 0;
}