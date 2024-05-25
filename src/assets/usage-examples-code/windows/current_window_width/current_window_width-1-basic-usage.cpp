#include "splashkit.h"

int main()
{
    open_window("Window Width Example", 800, 600);

    int width = current_window_width();

    write_line("The width of the current window is: " + std::to_string(width));

    return 0;
}
