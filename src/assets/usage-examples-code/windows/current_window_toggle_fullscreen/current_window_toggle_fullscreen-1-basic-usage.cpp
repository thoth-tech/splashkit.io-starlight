#include "splashkit.h"

int main()
{
    open_window("Fullscreen Toggle Example", 800, 600);

    write_line("Press any key to toggle fullscreen mode...");
    
    // Wait for user input
    read_line();

    // Toggle fullscreen mode
    current_window_toggle_fullscreen();

    write_line("Fullscreen mode toggled. Press any key to exit...");

    // Wait for user input to exit
    read_line();

    return 0;
}
