#include "splashkit.h"  

int main()
{
    // Open a window
    window my_window = open_window("Clear Window Example", 800, 600);

    // Define a color to clear the window with
    color my_color = rgb_color(100, 149, 237);  // Cornflower Blue

    // Clear the window with the specified color
    clear_window(my_window, my_color);

    // Refresh the window to apply changes
    refresh_window(my_window);

    // Pause to view the cleared window
    delay(5000);

    // Close the window
    close_window(my_window);

    return 0;
}
