// Demonstrates ray_circle_intersect_distance by drawing a ray and a circle.
// Shows the distance from the ray origin to the intersection point on the circle.

#include "splashkit.h"
#include <cmath>

// Define a minimal ray struct
struct ray
{
    point_2d origin;
    vector_2d direction;
};

// Manual implementation of ray_circle_intersect_distance
float ray_circle_intersect_distance(const ray &r, const circle &c)
{
    float dx = r.direction.x;
    float dy = r.direction.y;

    float fx = r.origin.x - c.center.x;
    float fy = r.origin.y - c.center.y;

    float a = dx * dx + dy * dy;
    float b = 2 * (fx * dx + fy * dy);
    float c_val = fx * fx + fy * fy - c.radius * c.radius;

    float discriminant = b * b - 4 * a * c_val;

    if (discriminant < 0)
        return -1; // No intersection

    discriminant = sqrt(discriminant);
    float t1 = (-b - discriminant) / (2 * a);
    float t2 = (-b + discriminant) / (2 * a);

    if (t1 >= 0) return t1;
    if (t2 >= 0) return t2;

    return -1;
}

int main()
{
    open_window("Ray-Circle Intersection", 600, 400);

    ray r;
    r.origin = point_at(300, 200);          // Center of window
    r.direction = vector_to(1, 0);          // Pointing right
    circle c = circle_at(400, 200, 50);     // Circle to the right

    float dist = ray_circle_intersect_distance(r, c);

    clear_screen(COLOR_WHITE);
    draw_circle(COLOR_RED, c);
    draw_line(COLOR_BLUE, r.origin, point_at(r.origin.x + 600, r.origin.y));

    if (dist >= 0)
    {
        point_2d hit = point_at(r.origin.x + r.direction.x * dist, r.origin.y + r.direction.y * dist);
        draw_circle(COLOR_GREEN, hit.x, hit.y, 5);
    }

    refresh_screen();
    delay(3000);

    return 0;
}
