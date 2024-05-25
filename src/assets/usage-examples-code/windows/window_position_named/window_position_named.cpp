#include "splashkit.h"
#include <iostream>

int main()
{
    const std::string windowName = "My Window";

    // Open a window
    window myWindow = open_window(windowName, 800, 600);

    // Get the position of the window by name
    point_2d windowPosition = window_position(windowName);

    // Print the window position
    std::cout << "Position of window '" << windowName << "': X=" << windowPosition.x << ", Y=" << windowPosition.y << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
