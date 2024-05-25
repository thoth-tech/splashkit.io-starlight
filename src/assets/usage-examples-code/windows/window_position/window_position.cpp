#include "splashkit.h"
#include <iostream>

int main()
{
    // Open a window
    window myWindow = open_window("My Window", 800, 600);

    // Get the position of the window
    point_2d windowPosition = window_position(myWindow);

    // Print the window position
    std::cout << "Window position: X=" << windowPosition.x << ", Y=" << windowPosition.y << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
