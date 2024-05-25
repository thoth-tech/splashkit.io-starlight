#include "splashkit.h"

int main()
{
    // Open a window initially
    window myWindow = open_window("My Window", 800, 600);

    // Wait for a short time
    delay(2000);

    // Toggle fullscreen mode
    window_toggle_fullscreen("My Window");

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
