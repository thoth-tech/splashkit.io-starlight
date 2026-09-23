#include "splashkit.h"

int main()
{
    open_window("Interface Element Shadows", 700, 420);

    int shadow_radius = 3;
    point_2d shadow_offset = point_at(3, 3);
    color shadow_color = rgba_color(0, 0, 0, 140);
    string shadow_style = "Small shadow";

    while (!quit_requested())
    {
        process_events();

        // Change the interface shadow using number keys
        if (key_typed(NUM_1_KEY))
        {
            shadow_radius = 3;
            shadow_offset = point_at(3, 3);
            shadow_style = "Small shadow";
        }

        if (key_typed(NUM_2_KEY))
        {
            shadow_radius = 15;
            shadow_offset = point_at(15, 15);
            shadow_style = "Large shadow";
        }

        // Apply the selected shadow style to interface elements
        set_interface_element_shadows(
            shadow_radius,
            shadow_color,
            shadow_offset
        );

        clear_screen(color_white());

        draw_text(
            "Press 1 for small shadow or 2 for large shadow",
            color_black(),
            130,
            80
        );

        draw_text(
            "Current style: " + shadow_style,
            color_black(),
            240,
            130
        );

        button(
            "Interface Button",
            rectangle_from(230, 200, 240, 60)
        );

        draw_interface();
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}