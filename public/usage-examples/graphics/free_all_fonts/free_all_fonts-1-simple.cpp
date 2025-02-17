#include "splashkit.h"

int main() 
{
    // Open a window with the title "Free All Front" and dimensions 800x600
    open_window("Free All Front", 800, 600);

    // Load the "Arial" font from the file "arial.ttf"
    load_font("Arial", "arial.ttf");

    // Draw text "Old Theme" in black color using the "Arial" font at position (100, 100)
    draw_text("Old Theme", COLOR_BLACK, "Arial", 24, 100, 100);

    // Refresh the screen to display the text
    refresh_screen(); 

    // Pause for 2000 milliseconds (2 seconds) to display the old theme
    delay(2000);

    // Free all fonts to reset the theme
    void free_all_fonts();

    // Clear the screen to prepare for the new theme
    clear_screen();

    // Load the "Verdana" font from the file "verdana.ttf"
    load_font("Verdana", "verdana.ttf");

    // Draw text "New Theme" in blue color using the "Verdana" font at position (100, 100)
    draw_text("New Theme", COLOR_BLUE, "Verdana", 24, 100, 100);

    // Refresh the screen to display the updated text
    refresh_screen(); 

    // Pause for 3000 milliseconds (3 seconds) to display the new theme
    delay(3000);

    return 0;
}
