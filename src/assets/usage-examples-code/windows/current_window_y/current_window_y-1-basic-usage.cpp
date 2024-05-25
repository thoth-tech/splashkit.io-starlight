#include "splashkit.h"

int main()
{
    open_window("Window Y Coordinate Example", 800, 600);

    int y_position = current_window_y();

    write_line("The y-coordinate of the current window is: " + std::to_string(y_position));

    return 0;
}
