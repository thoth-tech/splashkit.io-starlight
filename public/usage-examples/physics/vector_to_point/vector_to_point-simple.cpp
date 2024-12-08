#include "splashkit.h"

int main()
{
    // Define a point
    point_2d my_point_1 = {200, 100};

    // Create a vector pointing to the point
    vector_2d my_vector_1 = vector_to(my_point_1);

    // Output the vector
    write_line("my_vector_1 values: " + vector_to_string(my_vector_1));

    return 0;
}
