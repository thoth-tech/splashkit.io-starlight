#include "splashkit.h"

int main()
{
    open_window("Widest Points on a Circle", 800, 600);

    circle demo_circle = circle_at(400, 300, 120);

    while (!quit_requested())
    {
        process_events();

        // Use the mouse position to define the direction vector
        point_2d center = center_point(demo_circle);
        point_2d mouse_pt = mouse_position();
        vector_2d along = vector_point_to_point(center, mouse_pt);

        // Calculate the two points on the circle along the vector
        point_2d pt1;
        point_2d pt2;
        widest_points(demo_circle, along, pt1, pt2);

        clear_screen(COLOR_WHITE);

        // Draw the circle and the direction being tested
        draw_circle(COLOR_BLACK, demo_circle);
        draw_line(COLOR_GRAY, center, mouse_pt);

        // Draw the widest points returned by the function
        draw_line(COLOR_BLUE, pt1, pt2);
        fill_circle(COLOR_RED, pt1.x, pt1.y, 6);
        fill_circle(COLOR_RED, pt2.x, pt2.y, 6);

        draw_text("Move the mouse to change the vector.", COLOR_BLACK, 20, 20);
        draw_text("The red points are the widest points on the circle.", COLOR_BLUE, 20, 50);

        refresh_screen(60);
    }

    return 0;
}