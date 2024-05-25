#include <iostream>
#include "splashkit.h"

int main()
{
    open_window("My Window", 800, 600);
    std::cout << "Window width: " << screen_width() << std::endl;
    delay(2000);  // Wait for 2 seconds before closing the window
    close_all_windows();
    return 0;
}
