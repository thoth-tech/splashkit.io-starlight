#include "splashkit.h"

int main()
{
    // Open a window for the border‐color demo
    open_window("Border Interface Color", 400, 200);

    // Set all interface borders (e.g. buttons) to red
    set_interface_border_color(color_red());

    // Define a button area
    rectangle btn_rect = rectangle_from(150, 80, 100, 40);

    // Main loop: draw the button with our custom border color
    while (!quit_requested())
    {
        process_events();
        clear_screen(color_white());

        // Render the button using the interface border color
        button("Click Me", btn_rect);
        draw_interface();

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
