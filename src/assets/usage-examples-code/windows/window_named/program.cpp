#include "splashkit.h"
#include <iostream>

int main()
{
    const std::string windowName = "My Window";

    // Open a window
    window myWindow = open_window(windowName, 800, 600);

    // Retrieve the window using its name
    window retrievedWindow = window_named(windowName);

    // Check if the retrieved window is valid
    bool isValid = (retrievedWindow == myWindow);

    // Print the result
    std::cout << "Is the retrieved window the same as the created one? " << std::boolalpha << isValid << std::endl;

    // Keep the window open until manually closed
    while (!window_close_requested(myWindow))
    {
        process_events();
        delay(100);
    }

    return 0;
}
