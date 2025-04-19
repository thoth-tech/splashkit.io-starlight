#include "splashkit.h"
#include <vector>

int main()
{
    open_window("Lines From Rectangle Example", 800, 600);

    // Rectangle setup
    float x = (800 - 300) / 2;
    float y = (600 - 200) / 2;
    rectangle my_rect = rectangle_from(x, y, 300, 200);

    vector<line> rect_edges = lines_from(my_rect);

    color normal_colors[4] = { COLOR_RED, COLOR_LIME_GREEN, COLOR_BLUE, COLOR_YELLOW };
    color hover_colors[4]  = { COLOR_WHITE, COLOR_WHITE, COLOR_WHITE, COLOR_WHITE };

    while (!window_close_requested("Lines From Rectangle Example"))
    {
        process_events();  // prevent freezing
        clear_screen(COLOR_DARK_SLATE_GRAY);
        fill_rectangle(COLOR_BLACK, my_rect);

        point_2d mouse = mouse_position();

        for (int i = 0; i < 4; i++)
        {
            if (point_on_line(mouse, rect_edges[i]))
            {
                draw_line(hover_colors[i], rect_edges[i]);
            }
            else
            {
                draw_line(normal_colors[i], rect_edges[i]);
            }
        }

        refresh_screen();
        delay(10); // prevent 100% CPU
    }

    return 0;
}