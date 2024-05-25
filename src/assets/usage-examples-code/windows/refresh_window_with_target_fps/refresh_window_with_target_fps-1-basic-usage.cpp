#include "splashkit.h"

int main()
{
    window wind = open_window("Refresh Window with Target FPS Example", 800, 600);

    unsigned int target_fps = 60;

    write_line("Refreshing the window with a target FPS of " + std::to_string(target_fps) + "...");

    while (!window_close_requested(wind))
    {
        process_events();
        clear_window(wind, COLOR_WHITE);
        draw_text("Window will be refreshed at " + std::to_string(target_fps) + " FPS.", COLOR_BLACK, 50, 50);
        refresh_window(wind, target_fps);
    }

    return 0;
}
