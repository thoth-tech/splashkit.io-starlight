#include "splashkit.h"

int main()
{
    open_window("Point At", 800, 600);
    clear_screen();

    for (int i = 0; i < 30; i++)
    {
        int x1 = rnd(800);
        int y1 = rnd(600);

        // Create a point at position (400,300)
        point_2d point = point_at(x1, y1);

        color randomColor = rgb_color(rnd(255), rnd(255), rnd(255));
        // Create circle at the point
        fill_circle(randomColor, point.x, point.y, 4);
        fill_circle(randomColor, point.x + 20, point.y, 4);
        fill_rectangle(randomColor, point.x + 10, point.y + 10, 10, 10);
    }

    // Create a point at middle of the screen
    point_2d pointMiddle = point_at(400, 300);

    // Draw the point
    fill_circle(COLOR_RED, pointMiddle.x, pointMiddle.y, 4);
    draw_text("Center Point", COLOR_BLACK, pointMiddle.x - 20, pointMiddle.y - 20);

    refresh_screen();
    delay(4000);
    close_all_windows();
}