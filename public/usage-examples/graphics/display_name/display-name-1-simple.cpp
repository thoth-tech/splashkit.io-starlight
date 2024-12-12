#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Display Name", 800, 600);

    // Load a font
    load_font("Arial", "arial.ttf");

    // Loop through all displays and print their details
    for (int i = 0; i < number_of_displays(); i++)
    {
        display disp = display_details(i); // Get the name of the display
         
        draw_text("NAME: "  + display_name(disp), COLOR_BLACK, "Arial", 24, 100, 100);
    }

    // Refresh the screen to show the drawn text
    refresh_screen();
    delay(5000);

    // Close all windows
    close_all_windows();
}