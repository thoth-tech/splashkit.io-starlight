#include "splashkit.h"

int main()
{
    // Open a window for displaying the interface
    open_window("Button Click Example", 600, 400);

    // Define the background color and button rectangle
    color bg_color = COLOR_WHITE;
    rectangle btn_rect = rectangle_from(200, 180, 200, 40);

    // Main loop
    while (!quit_requested())
    {
        process_events();

        // If the button is clicked, toggle the background color
        if (button("Click Me!", btn_rect))
        {
            bg_color = (bg_color == COLOR_WHITE) ? COLOR_LIGHT_BLUE : COLOR_WHITE;
        }

        // Clear screen and draw the interface
        clear_screen(bg_color);
        draw_interface();
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
