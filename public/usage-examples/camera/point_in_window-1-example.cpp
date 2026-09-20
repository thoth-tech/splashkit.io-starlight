#include "splashkit.h"

int main()
{
    int window_width = 800;
    double point_x = -30;
    double movement_speed = 2;
    window demo_window = open_window("Moving Point Boundary Check", window_width, 500);

    while (!quit_requested())
    {
        process_events();

        // Move the point across both window boundaries to show both results.
        point_x += movement_speed;
        if (point_x > window_width + 30)
        {
            point_x = -30;
        }

        point_2d test_point = point_at(point_x, 300);
        bool point_is_inside = point_in_window(demo_window, test_point);

        clear_screen(rgb_color(24, 31, 46));
        draw_text("POINT IN WINDOW", color_white(), 315, 70);
        draw_text("The yellow point moves through the window boundaries.", color_white(), 225, 120);
        draw_text("point_in_window result:", color_white(), 300, 185);

        if (point_is_inside)
        {
            draw_text("TRUE - POINT IS INSIDE", color_green(), 300, 225);
            fill_circle(color_yellow(), test_point, 15);
        }
        else
        {
            draw_text("FALSE - POINT IS OUTSIDE", color_red(), 295, 225);
        }

        draw_line(color_white(), 0, 300, window_width, 300);
        draw_text("Close the window to finish.", color_white(), 310, 430);

        // A steady refresh rate keeps the movement easy to follow.
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
