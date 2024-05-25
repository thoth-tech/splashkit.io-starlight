#include "splashkit.h"

int main()
{
    // Open a window to find its height
    open_window("Window", 800, 600);

    // Get the height of the current window
    int height = current_window_height();

    // Print the height of the current window
    write_line("The height of the current window is: " + std::to_string(height));

    // Close the window
    delay(5000); 
    close_all_windows();

    return 0;
}
