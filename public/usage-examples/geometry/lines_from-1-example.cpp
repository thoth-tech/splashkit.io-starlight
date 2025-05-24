#include "splashkit.h"

int main()
{
    open_window("Interactive Rectangle Edges", 800, 600);

    float x = (800 - 300) / 2;
    float y = (600 - 200) / 2;
    rectangle my_rect = rectangle_from(x, y, 300, 200);

    // Get the four edges of the rectangle using the LinesFrom function
    vector<line> rect_edges = lines_from(my_rect);

    color normal_colors[4] = {
        COLOR_RED,
        COLOR_LIME_GREEN,
        COLOR_BLUE,
        COLOR_ORANGE
    };

    color hover_colors[4] = {
        COLOR_WHITE,
        COLOR_WHITE,
        COLOR_WHITE,
        COLOR_WHITE
    };

    while (!window_close_requested("Interactive Rectangle Edges"))
    {
        process_events();
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

        refresh_screen(60);
        delay(10);
    }

    return 0;
}
