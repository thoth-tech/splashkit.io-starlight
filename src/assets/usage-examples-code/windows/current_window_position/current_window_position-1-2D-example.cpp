#include "splashkit.h"

int main()
{
    // Open a window to get the current window position
    open_window("Check Fullscreen", 800, 600);
    
    // Get the current window position
    point_2d window_position = current_window_position();

    // Print the window position
    write_line("The current window position is: (" + std::to_string(window_position.x) + ", " + std::to_string(window_position.y) + ")");

    return 0;
}
