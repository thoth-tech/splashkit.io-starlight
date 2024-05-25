#include "splashkit.h"  

int main()
{
    // Open a window with a specific name
    window my_window = open_window("Close Named Window Example", 800, 600);

    // Display a message and wait for a few seconds
    write_line("The window will close in 5 seconds...");
    delay(5000);

    // Close the window with the specified name
    close_window("Close Named Window Example");

    return 0;
}
