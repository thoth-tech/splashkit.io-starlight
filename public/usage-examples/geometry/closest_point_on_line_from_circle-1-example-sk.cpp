#include "splashkit.h"

int main()
{
    open_window("Closest Point On Line From Circle", 800, 600);

    point_2d cursor_pos;
    point_2d closest_point_coordinates;
    point_2d line_start = point_at(300, 400);
    circle circle_shape = circle_at(point_at(250, 150), 100);
    circle red_dot;
    line line_shape;

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();
        line_shape = line_from(line_start, cursor_pos);

        // Point2D variable stores the x and y coordinates of the closest point between the circle and line
        closest_point_coordinates = closest_point_on_line_from_circle(circle_shape, line_shape);
        red_dot = circle_at(closest_point_coordinates, 5);

        clear_screen();
        draw_circle(color_black(), circle_shape);
        draw_line(color_black(), line_shape);
        fill_circle(color_red(), red_dot);

        draw_text("Position of closest point on line from circle: " + point_to_string(closest_point_coordinates), color_black(), 110, 500);
        refresh_screen();
    }
    close_all_windows();
    return 0;
}