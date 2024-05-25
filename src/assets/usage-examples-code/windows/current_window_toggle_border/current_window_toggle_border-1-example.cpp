#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Toggle Border", 800, 600);

    // Toggle the window border
    current_window_toggle_border();

    // Wait for a key press before closing the window
    while (not quit_requested())
    {
        process_events();
    }

    return 0;
}
