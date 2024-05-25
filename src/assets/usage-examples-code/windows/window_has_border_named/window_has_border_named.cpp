#include "splashkit.h"
#include <iostream>

int main()
{
    // Check if the window named "My Window" has a border
    bool has_border = window_has_border_named("My Window");

    // Print the result
    if (has_border)
    {
        std::cout << "Window 'My Window' has a border." << std::endl;
    }
    else
    {
        std::cout << "Window 'My Window' does not have a border." << std::endl;
    }

    return 0;
}
