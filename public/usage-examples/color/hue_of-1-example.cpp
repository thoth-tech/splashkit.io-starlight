#include "splashkit.h"
#include <string>

int main()
{
    open_window("Hue Of", 800, 600);

    while (!quit_requested())
    {
        process_events();

        double selected_hue = mouse_x() / screen_width();

        if (selected_hue < 0.0)
        {
            selected_hue = 0.0;
        }
        else if (selected_hue > 1.0)
        {
            selected_hue = 1.0;
        }

        color selected_color = hsb_color(selected_hue, 1.0, 1.0);

        // Get the hue component of the selected color
        double hue = hue_of(selected_color);

        clear_screen(COLOR_WHITE);

        fill_rectangle(selected_color, 100, 120, 600, 300);
        draw_rectangle(COLOR_BLACK, 100, 120, 600, 300);

        draw_text(
            "Move the mouse left and right to change the color",
            COLOR_BLACK,
            150,
            60
        );

        draw_text(
            "Hue: " + std::to_string(hue),
            COLOR_BLACK,
            330,
            460
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}