#include "splashkit.h"

int main()
{
    window wind1 = open_window("Window 1", 800, 600);
    window wind2 = open_window("Window 2", 800, 600);

    write_line("Setting the current window to 'Window 1'...");
    set_current_window(wind1);
    write_line("Current window is now 'Window 1'.");

    delay(1000); // Delay to keep the window open for 1 second

    write_line("Setting the current window to 'Window 2'...");
    set_current_window(wind2);
    write_line("Current window is now 'Window 2'.");

    delay(3000); // Delay to keep the window open for 3 seconds

    return 0;
}
