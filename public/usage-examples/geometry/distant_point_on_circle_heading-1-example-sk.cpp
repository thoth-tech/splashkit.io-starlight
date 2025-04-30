#include "splashkit.h"

int main()
{
    // Clear the screen with white color
    clear_screen(COLOR_WHITE);

    // Define the circle's center and radius
    point_2d center = point_at(400, 300);
    float radius = 100;
    float heading = 90;
    point_2d from_point = point_at(100, 100);

    // Calculate the distant point on the circle at the given heading
    point_2d far_point = distant_point_on_circle_heading(center, radius, from_point, heading);

    // Draw the circle and the calculated point
    draw_circle(COLOR_BLUE, center, radius);
    draw_pixel(COLOR_RED, far_point);

    // Refresh the screen at 60 FPS
    refresh_screen(60);

    // Delay for 5000 milliseconds to keep the window open
    delay(5000);

    return 0;
}
