#include "splashkit.h"
#include <iostream>

int main()
{
    // Open a window
    window my_window = open_window("My Window", 800, 600);

    // Get the height of the window
    int height = window_height(my_window);

    // Print the height to the console
    std::cout << "Height of window 'My Window': " << height << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(my_window))
    {
        process_events();
        delay(100);
    }

    return 0;
}
