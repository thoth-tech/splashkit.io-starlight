#include "splashkit.h"

int main()
{
    open_window("Move Window Example", 800, 600);

    write_line("Moving the window to (100, 100)...");

    move_current_window_to(100, 100);

    write_line("Window moved to (100, 100).");

    return 0;
}
