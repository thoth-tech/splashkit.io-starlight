// Usage Example: distant_point_on_circle
// Shows the minimum to compute and visualize the farthest point on a circle from a given point.
// Expected: opens a 220×220 window, draws a grey circle, a red source point, and a blue far point, then exits.
// Docs: https://splashkit.io/api/geometry/#distant-point-on-circle

#include "splashkit.h"

int main()
{
    open_window("Distant Point On Circle", 220, 220);
    circle c = circle_at(point_at(110, 110), 70);
    point_2d pt = point_at(160, 120);
    point_2d far = distant_point_on_circle(pt, c);

    clear_screen(COLOR_WHITE);
    draw_circle(COLOR_GRAY, c);
    fill_circle(COLOR_RED, pt.x, pt.y, 4);
    fill_circle(COLOR_BLUE, far.x, far.y, 4);
    refresh_screen(60);
    delay(1500);
    return 0;
}
