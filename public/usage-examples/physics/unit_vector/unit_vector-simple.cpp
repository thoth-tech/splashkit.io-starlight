#include "splashkit.h"

using std::to_string;

int main()
{
    // Define the original vector
    vector_2d my_vector_1 = {200, 100};

    // Compute the unit vector
    vector_2d my_unit_vector_1 = unit_vector(my_vector_1);

    // Output the original vector and its magnitude
    write_line("Original Vector: " + vector_to_string(my_vector_1));
    write_line("Original Vector Magnitude: " + to_string(vector_magnitude(my_vector_1)));

    // Output the unit vector and its magnitude
    write_line("Unit Vector: " + vector_to_string(my_unit_vector_1));
    write_line("Unit Vector Magnitude: " + to_string(vector_magnitude(my_unit_vector_1)));

    return 0;
}
