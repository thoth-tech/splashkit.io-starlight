#include "splashkit.h"
#include <iostream>

int main()
{
    // Open a window initially
    window myWindow = open_window("My Window", 800, 600);

    // Get and print the window width
    std::cout << "Window width: " << window_width(myWindow) << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
    }

    return 0;
}
