#include "splashkit.h"

int main()
{
    window window = open_window("Closest Point On Line From Circle", 800, 600);

    point_2d cursor_pos;
    circle circle_shape = circle_at(point_at(250, 150), 100);
    line line_shape;
    point_2d closest_point_coordinates;

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();
        line_shape = line_from(point_at(300, 400), cursor_pos);

        // Point2D variable stores the x and y coordinates of the closest point between the circle and line
        closest_point_coordinates = closest_point_on_line_from_circle(circle_shape, line_shape);

        clear_screen();
        draw_circle(color_black(), circle_shape);
        draw_line(color_black(), line_shape);
        fill_circle(color_red(), circle_at(closest_point_coordinates, 5));

        draw_text("Position of closest point on line from circle: " + point_to_string(closest_point_coordinates), color_black(), 110, 500);
        refresh_screen();
    }
    close_window(window);
    return 0;
}
