#include "splashkit.h"
#include <iostream>

int main()
{
    // Open a window
    window my_window = open_window("My Window", 800, 600);
    
    // Check if the window has focus
    bool has_focus = window_has_focus(my_window);
    
    // Print the result
    if (has_focus)
    {
        std::cout << "Window 'My Window' has focus." << std::endl;
    }
    else
    {
        std::cout << "Window 'My Window' does not have focus." << std::endl;
    }
    
    // Keep the window open until manually closed
    while (!window_close_requested(my_window))
    {
        process_events();
        delay(100);
    }
    
    return 0;
}
