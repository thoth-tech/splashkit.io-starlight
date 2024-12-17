#include "splashkit.h"

int main()
{
    // Define the start and end points
    point_2d start_point = {200, 100};
    point_2d end_point = {-300, 150};

    // Calculate the vector from start point to end point
    vector_2d my_vector_1 = vector_point_to_point(start_point, end_point);

    // Output the vector
    write_line(vector_to_string(my_vector_1));

    return 0;
}
