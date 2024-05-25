#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Check Fullscreen", 800, 600);

    // Check if the window is in fullscreen mode
    bool is_fullscreen = current_window_is_fullscreen();
    write_line("Is the current window fullscreen? " + std::to_string(is_fullscreen));

    // Close the window
    delay(3000);  
    close_window("Check Fullscreen");
    
    return 0;
}
