#include "splashkit.h"

int main()
{
    open_window("Color To String", 800, 450);

    color colors[] = {color_red(), color_green(), color_blue(), color_orange(), color_purple()};
    string labels[] = {"Red", "Green", "Blue", "Orange", "Purple"};
    int rect_width = 120;
    int rect_height = 200;
    int start_x = 60;
    int start_y = 130;
    int gap = 20;

    clear_screen(color_white());

    draw_text("Color To String", color_black(), 315, 50);
    draw_text("Each colour displayed with its hex string value", color_black(), 220, 75);

    for (int i = 0; i < 5; i++)
    {
        int x = start_x + i * (rect_width + gap);

        fill_rectangle(colors[i], x, start_y, rect_width, rect_height);

        // Function used here ↓
        string hex = color_to_string(colors[i]);
        draw_text(labels[i], color_black(), x + 30, start_y + rect_height + 10);
        draw_text(hex, color_black(), x + 5, start_y + rect_height + 28);
    }

    refresh_screen();
    delay(5000);

    close_all_windows();
    return 0;
}
