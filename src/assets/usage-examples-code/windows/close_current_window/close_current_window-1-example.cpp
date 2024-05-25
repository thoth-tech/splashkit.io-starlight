#include "splashkit.h"  

int main()
{
    // Open a window
    window my_window = open_window("Close Current Window Example", 800, 600);

    // Display a message and wait for a few seconds
    write_line("The window will close in 5 seconds...");
    delay(5000);

    // Close the current window
    close_current_window();

    return 0;
}
