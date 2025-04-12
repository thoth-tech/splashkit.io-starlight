#include "splashkit.h"

int main()
{
    window window = open_window("Distant Point On Circle", 800, 600);

    point_2d cursor_pos;
    circle circle_shape = circle_at(point_at(400, 200), 100);
    point_2d distant_point_coordinates;

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();

        // Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
        distant_point_coordinates = distant_point_on_circle(cursor_pos, circle_shape);

        clear_screen();
        draw_circle(color_black(), circle_shape);
        fill_circle(color_red(), circle_at(distant_point_coordinates, 5));

        draw_text("Most distant point on circle's circumference from mouse cursor is: " + point_to_string(distant_point_coordinates), color_black(), 35, 500);
        refresh_screen();
    }
    close_window(window);
    return 0;
}