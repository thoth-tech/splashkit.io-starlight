#include "splashkit.h"

int main()
{
    // opens a new 800 * 600 window
    open_window("Distance From Ray To Circle", 800, 600);

    // sets the starting point of the ray on the left side of the screen
    point_2d ray_origin = point_at(0, 300);

    // sets the ending point of the ray on the right side of the screen
    point_2d ray_end = point_at(800, 100);

    // creates a direction vector pointing toward the right and slightly up
    vector_2d ray_direction = unit_vector(vector_to(ray_end));

    // creates a circle at the center of the window with a radius of 50
    circle circle_obj = circle_at(point_at(400, 300), 100);

    while (!quit_requested())
    {
        // clears the screen and fills it with white
        clear_screen();

        // draws a blue line representing the laser beam from left to right
        draw_line(COLOR_BLUE, ray_origin, ray_end);

        // draws the target circle in red at its specified location
        draw_circle(COLOR_RED, circle_obj);

        // checks if the ray intersects the circle and gets the distance to the hit point
        float distance = ray_circle_intersect_distance(ray_origin, ray_direction, circle_obj);

        // displays the distance to the circle
        draw_text("Distance to circle: " + std::to_string(distance), COLOR_BLACK, 100, 100);

        refresh_screen(60);
    }

    return 0;
}