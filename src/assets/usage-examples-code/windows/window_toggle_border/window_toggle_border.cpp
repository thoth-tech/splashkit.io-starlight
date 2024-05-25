#include "splashkit.h"

int main()
{
    // Open a window with a border initially
    window myWindow = open_window("My Window", 800, 600);

    // Wait for a short time
    delay(2000);

    // Toggle the border off
    window_toggle_border(myWindow);

    // Wait for a short time
    delay(2000);

    // Toggle the border back on
    window_toggle_border(myWindow);

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
