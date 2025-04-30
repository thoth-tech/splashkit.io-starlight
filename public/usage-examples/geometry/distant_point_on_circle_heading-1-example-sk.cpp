#include "splashkit.h"

int main()
{
    clear_screen(COLOR_WHITE);

    point_2d center = point_at(400, 300);
    float radius = 100;
    float heading = 90;
    point_2d from_point = point_at(100, 100);
    point_2d far_point = distant_point_on_circle_heading(center, radius, from_point, heading);

    draw_circle(COLOR_BLUE, center, radius);
    draw_pixel(COLOR_RED, far_point);

    refresh_screen(60);
    delay(5000);
    return 0;
}
