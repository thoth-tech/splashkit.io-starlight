#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Panel Example", 600, 400);

    while (!window_close_requested("Panel Example"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Define the panel
        rectangle panelArea = rectangle_from(50, 50, 500, 300);

        // Start the panel
        start_panel("MainPanel", panelArea);

        // Add Labels to the panel
        label_element("Hello, welcome to the panel example!");
        label_element("This panel is now finalized with end_panel()");

        // Finalize the panel - no more elements can be added after this point
        end_panel("MainPanel");

        // Draw the interface elements (all panels and labels)
        draw_interface();

        refresh_screen(60);
    }

    return 0;
}
