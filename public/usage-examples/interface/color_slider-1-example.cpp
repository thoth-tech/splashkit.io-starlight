#include "splashkit.h"

int main()
{
    // open window
    open_window("color slider demo", 800, 400);

    // start color + panel for sliders
    color current = COLOR_SKY_BLUE;
    rectangle panel = rectangle_from(40, 40, 300, 140);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // update color using the sliders
        current = color_slider(current, panel);

        // preview rectangle
        fill_rectangle(current, 400, 40, 320, 140);

        draw_interface();
        refresh_screen();
    }

    close_all_windows();
    return 0;
}
