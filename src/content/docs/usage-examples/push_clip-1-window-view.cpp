#include "splashkit.h"

// Sun moves behind the house's window. push_clip limits drawing to the window;
// pop_clip restores normal drawing so the frame/house draw over the top.
int main()
{
    open_window("push_clip window view", 640, 360);
    rectangle win = rectangle_from(260, 130, 120, 80);
    double sun_x = 220;

    while (!quit_requested())
    {
        process_events();

        // Sky + ground
        clear_screen(COLOR_SKY_BLUE);
        fill_rectangle(COLOR_GREEN, 0, 300, 640, 60);

        // House
        fill_rectangle(COLOR_ORANGE, 200, 140, 240, 140);
        fill_triangle(COLOR_RED, 200, 140, 440, 140, 320, 90);

        // Clip to the window opening, draw the sun there only
        push_clip(win);
        fill_circle(COLOR_YELLOW, sun_x, 170, 22);
        pop_clip();

        // Draw the window frame last so it sits on top
        draw_rectangle(COLOR_WHITE, win);

        // Move the sun; loop it
        sun_x += 1.6; if (sun_x > 460) sun_x = 220;

        refresh_screen();
    }
    return 0;
}