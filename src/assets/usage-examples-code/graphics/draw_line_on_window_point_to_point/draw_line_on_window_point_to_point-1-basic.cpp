// I am drawing lines on the window by clicking a start point and an end point.
// I am left-clicking once for start; I am left-clicking again for end; I am pressing C to clear; I am pressing ESC to quit.

#include "splashkit.h"
#include <vector>

struct segment
{
    double x1, y1, x2, y2;
};

int main()
{
    // I am opening the window with a short ASCII title and explicit size.
    open_window("Draw Line - point to point on window", 720, 405);

    // I am keeping finished segments so I can redraw them every frame.
    std::vector<segment> segments;

    // I am remembering whether I have a start point for the current segment.
    bool has_start = false;
    double sx = 0.0, sy = 0.0; // I am storing the start point when I click the first time.

    while (!quit_requested())
    {
        process_events(); // I am polling input each frame.

        // I am handling quit and clear.
        if (key_typed(ESCAPE_KEY))
        {
            break; // I am exiting the loop when ESC is typed.
        }
        if (key_typed(C_KEY))
        {
            segments.clear(); // I am clearing the finished segments.
            has_start = false; // I am cancelling an in-progress segment as well.
        }

        // I am turning two clicks into one segment.
        if (mouse_clicked(LEFT_BUTTON))
        {
            const double mx = mouse_x();
            const double my = mouse_y();

            if (!has_start)
            {
                // I am recording the start point on the first click.
                has_start = true;
                sx = mx;
                sy = my;
            }
            else
            {
                // I am recording the end point on the second click and storing the segment.
                segments.push_back({sx, sy, mx, my});
                has_start = false;
            }
        }

        // I am rendering the frame.
        clear_screen(COLOR_WHITE);

        // I am drawing all finished segments in navy.
        for (const segment &s : segments)
        {
            draw_line(COLOR_NAVY, s.x1, s.y1, s.x2, s.y2);
        }

        // I am previewing the in-progress segment in orange from the start to the mouse.
        if (has_start)
        {
            const double mx = mouse_x();
            const double my = mouse_y();
            draw_line(COLOR_ORANGE_RED, sx, sy, mx, my);
            fill_circle(COLOR_ORANGE_RED, sx, sy, 3); // I am marking the start point.
        }

        // I am showing a small HUD with controls.
        draw_text("Click: start/end   C: clear   ESC: quit", COLOR_BLACK, 16, 16);

        refresh_screen(60); // I am pacing to ~60 FPS.
    }
    return 0;
}