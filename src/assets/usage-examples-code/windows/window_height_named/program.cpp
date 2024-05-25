#include "splashkit.h"
#include <iostream>

int main()
{
    const std::string windowName = "My Window";

    // Get the height of the window
    int height = window_height(windowName);

    // Print the height to the console
    std::cout << "Height of window '" << windowName << "': " << height << std::endl;

    // Open a window with the specified height
    window my_window = open_window(windowName, 800, height);

    // Keep the window open until manually closed
    while (!window_close_requested(my_window))
    {
        process_events();
        delay(100);
    }

    return 0;
}
