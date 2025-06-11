#include "splashkit.h"

int main()
{
    open_window("Closest Point on Line", 800, 600);

    circle circle = {{400, 300}, 50};  

    line line = line_from(point_2d{200, 100}, point_2d{600, 500}); 

    while (!window_close_requested("Closest Point on Line"))
    {
        process_events();

        circle.center = mouse_position();
        
        // Calculate the closest point on the line to the circle's center
        point_2d closest_point = closest_point_on_line_from_circle(circle, line);

        clear_screen(color_white());

        draw_line(color_red(), line.start_point, line.end_point);

        draw_circle(color_blue(), circle);

        fill_circle(color_green(), closest_point.x, closest_point.y, 5);

        refresh_screen();
    }

    return 0;
}
