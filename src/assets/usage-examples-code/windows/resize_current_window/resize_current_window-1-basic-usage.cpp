#include "splashkit.h"

int main()
{
    open_window("Resize Current Window Example", 800, 600);

    write_line("Resizing the window to 1024x768...");

    resize_current_window(1024, 768);

    write_line("Window resized to 1024x768.");

    delay(3000); // Delay to keep the window open for 3 seconds

    return 0;
}
