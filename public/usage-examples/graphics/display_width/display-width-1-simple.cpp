#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Display Width", 800, 600);

    // Load a font
    load_font("Arial", "arial.ttf");

    // Loop through all displays and print their width
    for (int i = 0; i < number_of_displays(); i++)
    {
        display disp = display_details(i); // Get the width of the display
        // Write display width to the screen
        draw_text("NAME: "  + std::to_string(display_width(disp)), COLOR_BLACK, "Arial", 24, 100, 100);
    }

    // Refresh the screen to show the drawn text
    refresh_screen();
    delay(5000);

    // Close all windows
    close_all_windows();
}