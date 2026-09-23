#include "splashkit.h"

int main()
{
    open_window("Vector From Angle", 800, 600);

    double angle = 0;
    const double length = 180;

    while (!quit_requested())
    {
        process_events();

        if (key_down(LEFT_KEY))
        {
            angle -= 2;
        }

        if (key_down(RIGHT_KEY))
        {
            angle += 2;
        }

        point_2d center = {
            screen_width() / 2.0,
            screen_height() / 2.0
        };

        vector_2d direction = vector_from_angle(angle, length);

        point_2d end_point = {
            center.x + direction.x,
            center.y + direction.y
        };

        clear_screen(COLOR_BLACK);

        draw_line(COLOR_BLUE, center.x, center.y, end_point.x, end_point.y);
        fill_circle(COLOR_YELLOW, end_point.x, end_point.y, 10);
        fill_circle(COLOR_WHITE, center.x, center.y, 6);

        draw_text("Angle: " + std::to_string((int)angle) + " degrees",
                  COLOR_WHITE, 20, 20);

        draw_text("Use Left and Right Arrow Keys",
                  COLOR_WHITE, 20, 50);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}