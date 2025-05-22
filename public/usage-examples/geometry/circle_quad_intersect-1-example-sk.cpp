#include "splashkit.h"

int main()
{
    open_window("Mouse Circle vs Rectangle Area", 800, 600);

    point_2d top_left = point_at(300, 200);
    point_2d top_right = point_at(500, 200);
    point_2d bottom_right = point_at(500, 400);
    point_2d bottom_left = point_at(300, 400);

    float radius = 30;

    point_2d mouse_pos;
    circle mouse_circle;
    quad fixed_quad = quad_from(top_left, top_right, bottom_right, bottom_left);
    bool is_intersecting;
    color quad_color;

    while (!window_close_requested("Mouse Circle vs Rectangle Area"))
    {
        process_events();
        clear_screen(COLOR_DARK_SLATE_GRAY);

        mouse_pos = mouse_position();
        mouse_circle = circle_at(mouse_pos.x, mouse_pos.y, radius);

        // Uses SplashKit's geometry function to detect intersection between the circle and quad
        is_intersecting = circle_quad_intersect(mouse_circle, fixed_quad);

        quad_color = is_intersecting ? COLOR_RED : COLOR_GREEN;

        fill_triangle(quad_color, top_left.x, top_left.y, top_right.x, top_right.y, bottom_right.x, bottom_right.y);
        fill_triangle(quad_color, top_left.x, top_left.y, bottom_left.x, bottom_left.y, bottom_right.x, bottom_right.y);

        draw_circle(COLOR_WHITE, mouse_circle);
        refresh_screen(60);
    }

    return 0;
}