#include "splashkit.h"

int main()
{
    window wind1 = open_window("Window 1", 800, 600);
    window wind2 = open_window("Window 2", 800, 600);

    if (is_current_window(wind1))
    {
        write_line("Window 1 is the current window.");
    }
    else
    {
        write_line("Window 1 is not the current window.");
    }

    if (is_current_window(wind2))
    {
        write_line("Window 2 is the current window.");
    }
    else
    {
        write_line("Window 2 is not the current window.");
    }

    return 0;
}
