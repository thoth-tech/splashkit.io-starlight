#include "splashkit.h"

int main()
{
    window window = open_window("Closest Point On Rect From Circle", 800, 600);

    // Rectangle for creating the point on
    rectangle rectangle_obj = rectangle_from(300, 200, 200, 150);

    while (!window_close_requested(window))
    {
        process_events();
        clear_screen(COLOR_WHITE);
        draw_rectangle(COLOR_BLACK, rectangle_obj);

        // Create circle at mouse position to make it dynamic
        point_2d mouse_pos = mouse_position();
        circle circle_obj = circle_at(mouse_pos, 30);
        fill_circle(COLOR_RED, circle_obj);

        // Get closest point on the rect to the circle and draw it
        point_2d closest_point = closest_point_on_rect_from_circle(circle_obj, rectangle_obj);
        circle point_on_rect = circle_at(closest_point, 5);
        fill_circle(COLOR_GREEN, point_on_rect);

        refresh_screen();
    }

    return 0;
}
