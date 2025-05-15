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

        // Alternate between light-blue and white to give click feedback
        if (button("Click Me!", btn_rect))
        {
            if (bg_color == COLOR_WHITE)
            {
                bg_color = COLOR_LIGHT_BLUE;
            }
            else
            {
                bg_color = COLOR_WHITE;
            }
        }

        // Clear screen and draw the interface
        clear_screen(bg_color);
        draw_interface();
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}