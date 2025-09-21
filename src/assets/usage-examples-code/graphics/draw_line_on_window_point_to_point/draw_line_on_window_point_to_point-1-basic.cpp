// I am drawing lines on the window by clicking a start point and an end point.
// Left-click once for start; left-click again for end; C clears; ESC is quitting.

#include "splashkit.h"
#include <vector>

struct segment
{
    double x1, y1, x2, y2;
};

int main()
{
    const int window_width = 720;
    const int window_height = 405;
    open_window("Draw Line — point to point on window", window_width, window_height);

    // I am keeping finished segments so I can show them every frame
    std::vector<segment> segments;

    // I am remembering the current start point (if any)
    bool has_start = false;
    double sx = 0.0, sy = 0.0;

    while (!quit_requested())
    {
        process_events();

        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(C_KEY))
        {
            segments.clear();
            has_start = false;
        }

        // I am handling clicks to create segments
        if (mouse_clicked(LEFT_BUTTON))
        {
            const double mx = mouse_x();
            const double my = mouse_y();

            if (!has_start)
            {
                // first click starts the segment
                has_start = true;
                sx = mx;
                sy = my;
            }
            else
            {
                // second click ends the segment
                segments.push_back({sx, sy, mx, my});
                has_start = false;
            }
        }

        clear_screen(COLOR_WHITE);

        // I am drawing all finished segments
        for (const segment &s : segments)
        {
            draw_line(COLOR_NAVY, s.x1, s.y1, s.x2, s.y2);
        }

        // I am showing a live preview from the start to the mouse
        if (has_start)
        {
            const double mx = mouse_x();
            const double my = mouse_y();
            draw_line(COLOR_ORANGE_RED, sx, sy, mx, my);
            fill_circle(COLOR_ORANGE_RED, sx, sy, 3);
        }

        // HUD (on-window text)
        draw_text("Click: start/end   C: clear   ESC: quit",
                  COLOR_BLACK, 16, 16);

        refresh_screen(60);
    }
    return 0;
}