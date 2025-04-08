#include "splashkit.h"

int main()
{
    // Open a window and load a font
    window my_window = open_window("Usage Example", 900, 600);
    
    font arial_font = load_font("Arial", "src/fonts/arial.ttf");

    // Main loop to keep the window open
    while (!window_close_requested(my_window))
    {
        process_events();
        
        clear_screen(COLOR_WHITE);
        
        // Display a message
        draw_text("Hello, This is Usage Example", COLOR_BLACK, arial_font, 32, 100, 100);
        
        refresh_screen(60);
    }

    // Free fonts and close the window
    free_all_fonts();
    close_window(my_window);

    return 0;
}
