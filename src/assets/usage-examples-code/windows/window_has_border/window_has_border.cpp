#include "splashkit.h"

int main()
{
    // Open a window
    window my_window = open_window("My Window", 800, 600);

    // Check if the window has a border
    bool has_border = window_has_border(my_window);

    // Set the background color
    if (has_border)
    {
        clear_screen(COLOR_WHITE);
    }
    else
    {
        clear_screen(COLOR_BLACK);
    }

    // Refresh the screen
    refresh_screen();

    // Close the window after a delay
    delay(2000); // Wait for 2 seconds
    close_window(my_window);

    return 0;
}
