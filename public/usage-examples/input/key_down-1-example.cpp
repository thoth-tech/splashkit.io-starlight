#include "splashkit.h"

int main()
{
    // Open a window to detect keyboard input
    open_window("Key Down Example", 400, 200);

    write_line("Press and hold Space...");

    // Keep checking until window is closed
    while (!quit_requested())
    {
        // Process keyboard and window events
        process_events();

        // Check if the space key is being held down
        if (key_down(SPACE_KEY))
        {
            write_line("Space key is held down!");
            delay(500);
        }
    }

    close_all_windows();
    return 0;
}