#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Test Window", 800, 600);

    // Check if the current window has a border
    bool hasBorder = current_window_has_border();

    // Display the result
    write_line("Does the current window have a border? " + string(hasBorder ? "Yes" : "No"));

    return 0;
}
