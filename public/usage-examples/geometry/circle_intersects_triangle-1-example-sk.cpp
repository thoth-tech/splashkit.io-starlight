#include "splashkit.h"

int main()
{
    open_window("Circle-Triangle Intersect", 600, 600);

    // A fixed triangle is placed as the target.
    triangle target = triangle_from(300, 100, 250, 300, 350, 300);

    // A circle moves with arrow keys.
    circle playerCircle;
    playerCircle.radius = 20;
    playerCircle.center = point_at(100, 100);

    while (!window_close_requested("Circle-Triangle Intersect"))
    {
        process_events();

        if (key_down(UP_KEY))    playerCircle.center.y -= 0.5;
        if (key_down(DOWN_KEY))  playerCircle.center.y += 0.5;
        if (key_down(LEFT_KEY))  playerCircle.center.x -= 0.5;
        if (key_down(RIGHT_KEY)) playerCircle.center.x += 0.5;

        clear_screen(COLOR_WHITE);
        draw_triangle(COLOR_BLACK, target);

        // The circle turns green and text is displayed if it touches the triangle.
        bool intersects = circle_triangle_intersect(playerCircle, target);
        color circleColor = intersects ? COLOR_GREEN : COLOR_RED;

        draw_circle(circleColor, playerCircle.center.x, playerCircle.center.y, playerCircle.radius);

        // Demonstrates the circle_triangle_intersect function.
        if (intersects)
        {
            draw_text("Circle is Intersecting the triangle", COLOR_BLACK, 170, 20);
        }

        refresh_screen(60);
    }

    return 0;
}
