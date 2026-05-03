#include "splashkit.h"
#include <string>

using namespace std;

int main()
{
    open_window("Live Window Position Monitor", 700, 250);

    while (!quit_requested())
    {
        process_events();

        point_2d pos = current_window_position();
        int x = current_window_x();
        int y = current_window_y();

        clear_screen(COLOR_WHITE);

        draw_text("Move the window to see the values update", COLOR_BLACK, 20, 20);
        draw_text("Current Window Position: (" + to_string((int)pos.x) + ", " + to_string((int)pos.y) + ")", COLOR_BLUE, 20, 70);
        draw_text("Current Window X: " + to_string(x), COLOR_RED, 20, 110);
        draw_text("Current Window Y: " + to_string(y), COLOR_GREEN, 20, 150);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}