#include "splashkit.h"
#include <string>
#include <cmath>

// Function to calculate tangent points from an external point to a circle
bool tangent_points(const point_2d &from_pt, const circle &c, point_2d &p1, point_2d &p2)
{
    vector_2d v = vector_point_to_point(c.center, from_pt);
    float d = vector_magnitude(v);

    if (d < c.radius) return false; // No tangents if inside the circle

    float r = c.radius;
    float angle_to_center = atan2(v.y, v.x);
    float angle_offset = acos(r / d);

    float angle1 = angle_to_center + angle_offset;
    float angle2 = angle_to_center - angle_offset;

    p1.x = c.center.x + r * cos(angle1);
    p1.y = c.center.y + r * sin(angle1);

    p2.x = c.center.x + r * cos(angle2);
    p2.y = c.center.y + r * sin(angle2);

    return true;
}

int main()
{
    open_window("Dynamic Tangents to Circle", 800, 600);

    point_2d external_point = {600, 150};
    point_2d tangent1, tangent2;

    circle c;
    c.center = {400, 300};
    c.radius = 100;

    while (!window_close_requested("Dynamic Tangents to Circle"))
    {
        process_events();

        // Update external point to current mouse position
        external_point.x = mouse_x();
        external_point.y = mouse_y();

        bool valid_tangents = tangent_points(external_point, c, tangent1, tangent2);

        clear_screen(COLOR_WHITE);

        // Draw circle
        draw_circle(COLOR_BLACK, c);

        // Draw external point
        fill_circle(COLOR_RED, external_point.x, external_point.y, 5);

        // Draw tangent points and lines if valid
        if (valid_tangents)
        {
            fill_circle(COLOR_BLUE, tangent1.x, tangent1.y, 5);
            fill_circle(COLOR_BLUE, tangent2.x, tangent2.y, 5);

            draw_line(COLOR_GREEN, external_point, tangent1);
            draw_line(COLOR_GREEN, external_point, tangent2);
        }

        // Display external point coordinates in top-left corner
        std::string coord_text = "External Point: (" + std::to_string((int)external_point.x) + ", " + std::to_string((int)external_point.y) + ")";
        draw_text(coord_text, COLOR_BLACK, "Arial", 16, 10, 10);

        refresh_screen(60);
    }

    return 0;
}
