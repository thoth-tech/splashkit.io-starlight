#include "splashkit.h"

int main()
{
    open_window("Circle Quad Intersect Example", 800, 600);

    // Define quad corners
    point_2d p1 = point_at(300, 200); // top-left
    point_2d p2 = point_at(500, 200); // top-right
    point_2d p3 = point_at(500, 400); // bottom-right
    point_2d p4 = point_at(300, 400); // bottom-left

    float radius = 30;

    while (!window_close_requested("Circle Quad Intersect Example"))
    {
        process_events();
        clear_screen(COLOR_DARK_SLATE_GRAY);

        // Create circle at mouse position
        point_2d mouse_pos = mouse_position();
        circle mouse_circle = circle_at(mouse_pos.x, mouse_pos.y, radius);

        // Build quad and check for intersection
        quad fixed_quad = quad_from(p1, p2, p3, p4);
        bool is_intersecting = circle_quad_intersect(mouse_circle, fixed_quad);

        // Set color based on intersection
        color quad_color = is_intersecting ? COLOR_RED : COLOR_GREEN;

        // Fill quad using two triangles (use .x and .y)
        fill_triangle(quad_color, p1.x, p1.y, p2.x, p2.y, p3.x, p3.y);
        fill_triangle(quad_color, p1.x, p1.y, p3.x, p3.y, p4.x, p4.y);

        // Draw the circle
        draw_circle(COLOR_WHITE, mouse_circle);

        refresh_screen(60);
    }

    return 0;
}