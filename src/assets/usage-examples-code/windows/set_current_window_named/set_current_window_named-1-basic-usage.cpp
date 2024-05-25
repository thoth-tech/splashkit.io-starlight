#include "splashkit.h"

int main()
{
    string window1_name = "Window 1";
    string window2_name = "Window 2";

    window wind1 = open_window(window1_name, 800, 600);
    window wind2 = open_window(window2_name, 800, 600);

    write_line("Setting the current window to '" + window1_name + "'...");
    set_current_window(window1_name);
    write_line("Current window is now '" + window1_name + "'.");

    delay(1000); // Delay to keep the window open for 1 second

    write_line("Setting the current window to '" + window2_name + "'...");
    set_current_window(window2_name);
    write_line("Current window is now '" + window2_name + "'.");

    delay(3000); // Delay to keep the window open for 3 seconds

    return 0;
}
