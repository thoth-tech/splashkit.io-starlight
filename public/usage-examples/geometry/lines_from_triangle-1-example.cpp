#include "splashkit.h"
#include <vector>
#include <string>
#include <algorithm>

int main()
{
    open_window("Lines From Triangle", 400, 400);


    //Build the triangle and grab its 3 edges
    triangle tri    = triangle_from(100, 100, 200,  80, 150, 200);
    std::vector<line> lines = lines_from(tri);

    const float R = 10.0f;  //circle radius

    while (!window_close_requested("Lines From Triangle"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        //Mouse x and y position
        float mx = mouse_x();
        float my = mouse_y();

        //Draw each line, highlighting if touched
        for (size_t i = 0; i < lines.size(); ++i)
        {
            line ln = lines[i];

            float x1 = ln.start_point.x, y1 = ln.start_point.y;
            float x2 = ln.end_point.x,   y2 = ln.end_point.y;

            float left   = std::min(x1, x2) - R;
            float right  = std::max(x1, x2) + R;
            float top    = std::min(y1, y2) - R;
            float bottom = std::max(y1, y2) + R;

            bool overlap = mx >= left && mx <= right && my >= top  && my <= bottom;

            color col = overlap ? COLOR_BLUE : COLOR_RED;
            draw_line(col, ln);

            float midx = (x1 + x2) * 0.5f;
            float midy = (y1 + y2) * 0.5f;
            draw_text(std::to_string(i), COLOR_BLACK, midx, midy);
        }

        //Draw a little circle around the mouse
        draw_circle(COLOR_GREEN, mx, my, R);

        refresh_screen();
    }

    return 0;
}
