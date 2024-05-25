#include "splashkit.h"

int main()
{
    // Load an existing bitmap as the icon
    bitmap iconBitmap = load_bitmap("existing_bitmap", "path/to/your/bitmap.png");

    // Open a window
    window myWindow = open_window("My Window", 800, 600);

    // Set the window icon
    window_set_icon(myWindow, iconBitmap);

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
