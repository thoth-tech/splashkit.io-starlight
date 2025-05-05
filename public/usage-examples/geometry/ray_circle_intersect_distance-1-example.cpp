#include "splashkit.h"

int main()
{
    // Opens a new window
    open_window("Distance From Ray To Circle", 800, 600);

    // Defines a laser beam from the left edge of the screen to the right
    point_2d ray_origin = point_at(0, 300);
    point_2d ray_end = point_at(800, 100);
    vector_2d ray_direction = unit_vector(vector_to(ray_end));

    // Defines a circle at the center of the window with a radius of 50
    circle target_circle = circle_at(point_at(400, 300), 100);

    while (!quit_requested())
    {
        clear_screen();

        // Draws a blue line representing the laser beam from left to right
        draw_line(COLOR_BLUE, ray_origin, ray_end);

        // Draws the target circle in red at its specified location
        draw_circle(COLOR_RED, target_circle);

        // Checks if the ray intersects the circle and gets the distance to the hit point
        float distance = ray_circle_intersect_distance(ray_origin, ray_direction, target_circle);

        // Displays the distance to the circle
        draw_text("Distance to circle: " + std::to_string(distance), COLOR_BLACK, 100, 100);

        refresh_screen(60);
    }

    return 0;
}