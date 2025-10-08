// Usage Example for: https://splashkit.io/api/graphics/#draw-triangle-3
// Goal: I am drawing a spinning equilateral triangle and I am toggling between outline and fill with SPACE.
// Why: I am showing how draw_triangle and fill_triangle render the same geometry differently.
// Controls: I am pressing SPACE to toggle fill | I am pressing ESC to quit.

#include "splashkit.h"
#include <cmath>

int main()
{
    const int WIDTH = 720, HEIGHT = 405;
    open_window("Spinning Triangle", WIDTH, HEIGHT);

    bool   is_filled = false;   // I am remembering whether I am filling or outlining.
    double angle     = 0.0;     // I am advancing the rotation angle each frame.
    const double PI  = 3.141592653589793;

    const double center_x = WIDTH * 0.5;  // I am placing the triangle at the window centre.
    const double center_y = HEIGHT * 0.5;
    const double radius   = 110.0;        // I am setting the radius from centre to a vertex.

    while (!quit_requested())
    {
        process_events();

        // I am quitting when ESC is pressed.
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }

        // I am toggling between outline and fill when SPACE is pressed.
        if (key_typed(SPACE_KEY))
        {
            is_filled = !is_filled;
        }

        clear_screen(COLOR_WHITE);

        // I am computing the three triangle points at 120° steps.
        const double a0 = angle;
        const double a1 = angle + 2.0 * PI / 3.0;
        const double a2 = angle + 4.0 * PI / 3.0;

        const double x1 = center_x + radius * std::cos(a0), y1 = center_y + radius * std::sin(a0);
        const double x2 = center_x + radius * std::cos(a1), y2 = center_y + radius * std::sin(a1);
        const double x3 = center_x + radius * std::cos(a2), y3 = center_y + radius * std::sin(a2);

        // I am drawing the triangle as filled or outlined.
        if (is_filled)
        {
            fill_triangle(COLOR_SKY_BLUE, x1, y1, x2, y2, x3, y3);
        }
        else
        {
            draw_triangle(COLOR_NAVY, x1, y1, x2, y2, x3, y3);
        }

        // I am drawing the on-screen help.
        draw_text("SPACE toggles fill | ESC quits", COLOR_BLACK, 16, 16);

        refresh_screen();
        delay(16);      // I am pacing to ~60 FPS.
        angle += 0.02;  // I am rotating at a comfortable speed.
    }

    return 0;
}