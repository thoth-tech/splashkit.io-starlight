#include "splashkit.h"

int main()
{
    string window_name = "Move Named Window Example";
    window wind = open_window(window_name, 800, 600);

    write_line("Moving the window '" + window_name + "' to (100, 100)...");

    move_window_to(window_name, 100, 100);

    write_line("Window '" + window_name + "' moved to (100, 100).");

    return 0;
}
