#include "splashkit.h" // needed to use SplashKit functions

int main() // starting point of the program
{
    // set up a ray pointing to the right so the result is easy to predict and verify
    point_2d ray_origin = point_at(100, 100);
    vector_2d ray_heading = vector_to(1, 0);

    // place the circle directly in the path of the ray so an intersection will happen
    circle target_circle = circle_at(250, 100, 50);

    // calculate how far the ray travels before it first touches the circle
    double hit_distance = ray_circle_intersect_distance(ray_origin, ray_heading, target_circle);

    // print the result so we can clearly see and check the returned distance
    write("Ray hit distance: ");
    write_line(hit_distance);

    return 0;
}


