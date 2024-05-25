#include "splashkit.h"

int main()
{
    open_window("Window X Coordinate Example", 800, 600);

    int x_position = current_window_x();

    write_line("The x-coordinate of the current window is: " + std::to_string(x_position));

    return 0;
}
