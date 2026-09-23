#include "splashkit.h"

int main()
{
    open_window("Color Blue", 600, 400);

    // The height of each bar in the chart
    int bar_heights[5] = {120, 200, 90, 260, 160};

    clear_screen(color_white());

    for (int i = 0; i < 5; i++)
    {
        int height = bar_heights[i];

        // Bars are drawn upwards from the base line at y = 340
        // Function used here ↓
        fill_rectangle(color_blue(), 80 + i * 100, 340 - height, 60, height);
    }

    // Draw the base line of the chart
    draw_line(color_black(), 50, 340, 550, 340);

    draw_text("Bars filled with color_blue", color_black(), 215, 360);

    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}
