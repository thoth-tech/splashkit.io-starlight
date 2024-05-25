#include "splashkit.h"
#include <iostream>

int main()
{
    const std::string windowName = "My Window";

    // Open a window
    window myWindow = open_window(windowName, 800, 600);

    // Check if the window is fullscreen
    bool isFullscreen = window_is_fullscreen(myWindow);

    // Print the result
    std::cout << "Is window '" << windowName << "' fullscreen? " << std::boolalpha << isFullscreen << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
