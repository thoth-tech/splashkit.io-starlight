#include "splashkit.h"
#include <iostream>

int main() {
    // Create a ray from origin pointing right
    point_2d ray_origin = point_at(0, 0);
    vector_2d ray_direction = vector_to(1, 0);
    
    // Create a circle to test intersection
    point_2d center_point = point_at(50, 0);
    circle target = circle_at(center_point, 25);
    
    // Calculate distance to circle intersection
    float distance = ray_circle_intersect_distance(ray_origin, ray_direction, target);
    
    std::cout << "Distance to circle: " << distance << std::endl;
    return 0;
}
