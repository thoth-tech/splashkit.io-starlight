#include "splashkit.h"

int main()
{
    // open a window
    window wind = open_window("Colour Changer", 600, 200);

    while (!quit_requested())
    {
        // get user events
        process_events();

        // clear screen
        clear_window(wind, COLOR_WHITE);

        // Buttons that change the colour of the screen
        if (button("Red!", rectangle_from(75, 85, 100, 30)))
        {
            clear_window(wind, COLOR_RED);
            refresh_window(wind);
            delay(1000);
            continue;
        }
        if (button("Green!", rectangle_from(250, 85, 100, 30)))
        {
            clear_window(wind, COLOR_GREEN);
            refresh_window(wind);
            delay(1000);
            continue;
        }

        if (button("Blue!", rectangle_from(425, 85, 100, 30)))
        {
            clear_window(wind, COLOR_BLUE);
            refresh_window(wind);
            delay(1000);
            continue;
        }

        draw_interface();
        refresh_window(wind);
    }

    // close all open windows
    close_all_windows();
}
