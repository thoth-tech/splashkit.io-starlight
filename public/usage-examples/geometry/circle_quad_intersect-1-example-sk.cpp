#include "splashkit.h"

int main()
{

    open_window("Mouse Circle vs Rectangle Area", 800, 600);

    // Define four corners of a quad
    point_2d top_left = point_at(300, 200);
    point_2d top_right = point_at(500, 200);
    point_2d bottom_right = point_at(500, 400);
    point_2d bottom_left = point_at(300, 400);

    // Assemble the quad using the corners
    quad fixed_quad = quad_from(top_left, top_right, bottom_right, bottom_left);

    float radius = 30;

    point_2d mouse_pos;
    circle mouse_circle;
    bool is_intersecting;
    color quad_color;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        mouse_pos = mouse_position();
        mouse_circle = circle_at(mouse_pos.x, mouse_pos.y, radius);

        is_intersecting = circle_quad_intersect(mouse_circle, fixed_quad);

        if (is_intersecting)
        {
            quad_color = COLOR_RED;
        }
        else
        {
            quad_color = COLOR_GREEN;
        }

        // Fill the quad using two triangles
        fill_triangle(quad_color, top_left.x, top_left.y, top_right.x, top_right.y, bottom_right.x, bottom_right.y);
        fill_triangle(quad_color, top_left.x, top_left.y, bottom_left.x, bottom_left.y, bottom_right.x, bottom_right.y);

        draw_circle(COLOR_BLACK, mouse_circle);

        refresh_screen();
    }

    close_all_windows();
    
    return 0;
}