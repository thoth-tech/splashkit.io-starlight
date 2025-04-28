#include "splashkit.h"
#include <string>
#include <cmath>

// Function to calculate the widest points of a circle along a given vector
void widest_points(const circle &c, const vector_2d &along, point_2d &pt1, point_2d &pt2)
{
    vector_2d unit = unit_vector(along);                         // Normalize the direction vector
    vector_2d offset = vector_multiply(unit, c.radius);          // Scale to circle radius

    pt1.x = c.center.x + offset.x;  // Point in the direction of the vector
    pt1.y = c.center.y + offset.y;

    pt2.x = c.center.x - offset.x;  // Point in the opposite direction
    pt2.y = c.center.y - offset.y;
}

int main()
{
    open_window("Widest Points Example", 800, 600);

    // Define the circle
    circle my_circle;
    my_circle.radius = 100;
    my_circle.center = point_at(400, 300); // Center in the window

    // Define the vector (direction)
    vector_2d direction = vector_point_to_point(point_at(0, 0), point_at(1, 2));
    direction = unit_vector(direction); // Normalize the vector

    // Calculate the widest points along that vector
    point_2d pt1, pt2;
    widest_points(my_circle, direction, pt1, pt2);

    // Main Loop
    while (!window_close_requested("Widest Points Example"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // The main circle
        draw_circle(COLOR_SKY_BLUE, my_circle);

        // The vector line from center in the direction
        point_2d vector_end = point_at(
            my_circle.center.x + direction.x * my_circle.radius,
            my_circle.center.y + direction.y * my_circle.radius
        );
        draw_line(COLOR_DARK_GRAY, my_circle.center, vector_end);

        // The widest points as small red dots
        draw_circle(COLOR_RED, pt1.x, pt1.y, 5);
        draw_circle(COLOR_RED, pt2.x, pt2.y, 5);

        // Display coordinates
        draw_text("Widest Points of Circle Along Vector", COLOR_BLACK, 10, 10);
        draw_text("Vector: (" + std::to_string(direction.x) + ", " + std::to_string(direction.y) + ")", COLOR_BLACK, 10, 30);
        draw_text("Point 1: (" + std::to_string(pt1.x) + ", " + std::to_string(pt1.y) + ")", COLOR_BLACK, 10, 50);
        draw_text("Point 2: (" + std::to_string(pt2.x) + ", " + std::to_string(pt2.y) + ")", COLOR_BLACK, 10, 70);

        refresh_screen(60);
    }

    return 0;
}
