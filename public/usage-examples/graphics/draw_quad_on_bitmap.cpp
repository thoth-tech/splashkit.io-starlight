#include "splashkit.h"

int main()
{
    open_window("Dart-Shaped Quad", 800, 600);

    // Dart shape points
    point_2d dart[] = {
        {400, 100},  // A - Top
        {500, 300},  // C - Right
        {400, 500},  // B - Bottom
        {300, 300}   // D - Left
    };

    while (!window_close_requested("Dart-Shaped Quad"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Use fill_triangle with raw coordinate values instead of point_2d
        fill_triangle(COLOR_SKY_BLUE,
                      dart[0].x, dart[0].y,
                      dart[1].x, dart[1].y,
                      dart[2].x, dart[2].y);

        fill_triangle(COLOR_SKY_BLUE,
                      dart[2].x, dart[2].y,
                      dart[3].x, dart[3].y,
                      dart[0].x, dart[0].y);

        // Draw outline
        draw_line(COLOR_BLUE, dart[0], dart[1]);
        draw_line(COLOR_BLUE, dart[1], dart[2]);
        draw_line(COLOR_BLUE, dart[2], dart[3]);
        draw_line(COLOR_BLUE, dart[3], dart[0]);

        refresh_screen(60);
    }

    return 0;
}
