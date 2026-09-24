#include "splashkit.h"

int main()
{
    open_window("Alpha Of", 800, 450);

    int alphas[] = {50, 100, 150, 200, 255};
    int rect_width = 120;
    int rect_height = 200;
    int start_x = 60;
    int start_y = 140;
    int gap = 20;

    clear_screen(color_white());

    // Draw a background stripe so transparency is visible
    fill_rectangle(color_light_blue(), 0, start_y, 800, rect_height);

    draw_text("Transparency Layers", color_black(), 300, 55);
    draw_text("Same colour at different alpha values (light blue shows through)", color_black(), 155, 80);

    for (int i = 0; i < 5; i++)
    {
        color c = rgba_color(200, 50, 50, alphas[i]);
        int x = start_x + i * (rect_width + gap);

        fill_rectangle(c, x, start_y, rect_width, rect_height);

        // Function used here ↓
        int a = alpha_of(c);
        draw_text("Alpha: " + std::to_string(a), color_black(), x + 22, start_y + rect_height + 12);
    }

    refresh_screen();
    delay(5000);

    close_all_windows();
    return 0;
}
