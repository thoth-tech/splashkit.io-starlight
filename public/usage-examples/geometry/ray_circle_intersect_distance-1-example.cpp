#include "splashkit.h"

int main()
{
    // opens a new 800 * 600 window
    open_window("Ray-Circle Intersect Distance", 800, 600);

    // sets the starting point of the ray (laser) on the left side of the screen
    point_2d ray_origin = point_at(100, 200);

    // creates a direction vector pointing horizontally across the screen
    vector_2d ray_direction = unit_vector(vector_to(point_at(700, 300)));

    // creates a circle at the center of the window with a radius of 50
    circle circle_obj;
    circle_obj.center = point_at(400, 300);
    circle_obj.radius = 100;

    // runs the simulation loop until the user closes the window
    while (!quit_requested())
    {
        // clears the screen and fills it with white
        clear_screen(COLOR_WHITE);

        // calculates the end point of the laser beam
        point_2d ray_end = point_offset_by(ray_origin, vector_multiply(ray_direction, 800));

        // draws a blue line representing the laser beam from left to right
        draw_line(COLOR_BLUE, ray_origin, ray_end);

        // draws the target circle in red at its specified location
        draw_circle(COLOR_RED, circle_obj.center.x, circle_obj.center.y, circle_obj.radius);

        // checks if the ray intersects the circle and gets the distance to the hit point
        float distance = ray_circle_intersect_distance(ray_origin, ray_direction, circle_obj);

        // if the ray actually hits the circle, calculate the hit point and mark it with a green dot
        if (distance > 0)
        {
            vector_2d scaled_direction = vector_multiply(ray_direction, distance);
            point_2d hit_point = point_offset_by(ray_origin, scaled_direction);
            fill_circle(COLOR_GREEN, hit_point.x, hit_point.y, 5);
        }

        // updates the display at 60 frames per second
        refresh_screen(60);
    }

    return 0;
}