#include "splashkit.h"

int main()
{
    open_window("Circle Intersection (Values)", 600, 600);

    // Static circle parameters
    point_2d center = screen_center();
    const double c1_x = center.x;
    const double c1_y = center.y;
    const double c1_r = 80.0;

    while (!quit_requested())
    {
        process_events();

        // Mouse‐controlled circle parameters
        point_2d mp = mouse_position();
        const double c2_x = mp.x;
        const double c2_y = mp.y;
        const double c2_r = 50.0;

        // Determines if two circles overlap by comparing the distance between their centers to the sum of their radii
        bool hit = circles_intersect(
            c1_x, c1_y, c1_r,
            c2_x, c2_y, c2_r
        );

        // Red background on hit, white otherwise
        clear_screen(hit ? COLOR_RED : COLOR_WHITE);

        // Draw both circles by raw values
        fill_circle(COLOR_BLUE,  c1_x, c1_y, c1_r);
        fill_circle(COLOR_GREEN, c2_x, c2_y, c2_r);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
