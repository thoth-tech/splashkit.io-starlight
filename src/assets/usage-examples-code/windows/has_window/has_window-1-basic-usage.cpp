#include "splashkit.h"

int main()
{
    string caption = "Test Window";
    open_window(caption, 800, 600);

    if (has_window(caption))
    {
        write_line("A window with the caption '" + caption + "' exists.");
    }
    else
    {
        write_line("No window with the caption '" + caption + "' exists.");
    }

    return 0;
}
