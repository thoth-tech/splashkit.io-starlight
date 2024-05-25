#include "splashkit.h" 

int main()
{
    // Open a window
    window my_window = open_window("Close Window Example", 800, 600);

    // Display a message and wait for a few seconds
    write_line("The window will close in 5 seconds...");
    delay(5000);

    // Close the window
    close_window(my_window);

    return 0;
}
