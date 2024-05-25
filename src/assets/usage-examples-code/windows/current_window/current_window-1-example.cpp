#include "splashkit.h"

int main()
{
    // Open two windows
    window window1 = open_window("Window 1", 800, 600);
    window window2 = open_window("Window 2", 800, 600);

    // Display a message and wait for a few seconds
    write_line("Activating and then retrieving the current window in 5 seconds...");
    delay(5000);

    // Retrieve the current active window by switching context
    window current = current_window();

    // Print the title of the current active window
    write_line("The current active window is: " + window_caption(current));

    // Close the windows
    close_window(window1);
    close_window(window2);

    return 0;
}
