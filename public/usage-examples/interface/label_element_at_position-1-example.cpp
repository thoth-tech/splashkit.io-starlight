#include "splashkit.h"

int main()
{
    string heading_text = "Interface Labels";
    string first_label = "Welcome to SplashKit";
    string second_label = "This is a label element";

    open_window("Simple Interface Layout", 800, 600);

    set_interface_style(SHADED_LIGHT_STYLE);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display labels in a centered vertical layout.
        label_element(heading_text, rectangle_from(320, 300, 400, 40));
        label_element(first_label, rectangle_from(300, 250, 400, 40));
        label_element(second_label, rectangle_from(300, 200, 400, 40));

        draw_interface();

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}