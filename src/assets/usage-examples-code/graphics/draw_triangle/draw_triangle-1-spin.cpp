// I am drawing a spinning triangle; SPACE is toggling fill; ESC is quitting.
#include "splashkit.h"
#include <cmath>

int main()
{
    const int W = 720, H = 405;
    open_window("Spinning Triangle — SPACE toggles fill", W, H);

    bool   filled = false;         // I am remembering whether I am filling or outlining.
    double angle  = 0.0;           // I am advancing the rotation angle each frame.
    const double PI = 3.141592653589793;

    const double cx = W * 0.5;     // I am placing the triangle at the window centre.
    const double cy = H * 0.5;
    const double r  = 110.0;       // I am setting the radius from centre to a vertex.

    while (!quit_requested())
    {
        process_events();

        // I am quitting when ESC is pressed.
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }

        // I am toggling fill mode on SPACE.
        if (key_typed(SPACE_KEY))
        {
            filled = !filled;
        }

        clear_screen(COLOR_WHITE);

        // I am computing the three triangle points at 120° steps.
        double a0 = angle;
        double a1 = angle + 2.0 * PI / 3.0;
        double a2 = angle + 4.0 * PI / 3.0;

        double x1 = cx + r * cos(a0);
        double y1 = cy + r * sin(a0);
        double x2 = cx + r * cos(a1);
        double y2 = cy + r * sin(a1);
        double x3 = cx + r * cos(a2);
        double y3 = cy + r * sin(a2);

        if (filled)
        {
            fill_triangle(COLOR_SKY_BLUE, x1, y1, x2, y2, x3, y3);
        }
        else
        {
            draw_triangle(COLOR_NAVY, x1, y1, x2, y2, x3, y3);
        }

        draw_text("SPACE toggles fill  •  ESC quits", COLOR_BLACK, 16, 16);

        refresh_screen(60);
        angle += 0.03;
    }

    return 0;
}