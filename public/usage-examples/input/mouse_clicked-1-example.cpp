#include "splashkit.h"
#include <vector>

int main()
{
    open_window("Click to Place Markers", 800, 600);

    std::vector<point_2d> clicks;

    while (!quit_requested())
    {
        process_events();

        // Add a marker where the left mouse button was clicked
        if (mouse_clicked(LEFT_BUTTON))
        {
            clicks.push_back(mouse_position());
        }

        clear_screen(color_white());

        for (const point_2d &pt : clicks)
        {
            fill_circle(COLOR_RED, pt.x, pt.y, 8);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}