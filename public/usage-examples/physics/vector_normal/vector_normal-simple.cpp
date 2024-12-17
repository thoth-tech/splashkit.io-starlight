#include "splashkit.h"

using std::to_string;

int main()
{
    // Define vectors
    vector_2d my_vector_1 = {200, 100};
    vector_2d my_vector_2 = {0, 0};

    // Calculate normals
    vector_2d my_vector_1_normal = vector_normal(my_vector_1);
    vector_2d my_vector_2_normal = vector_normal(my_vector_2);

    // Display results for the first vector
    write_line("Original Vector: " + vector_to_string(my_vector_1));
    write_line("Original Vector Magnitude: " + to_string(vector_magnitude(my_vector_1)));
    write_line("Vector Normal: " + vector_to_string(my_vector_1_normal));
    write_line("Vector Normal Magnitude: " + to_string(vector_magnitude(my_vector_1_normal)));

    // Display results for the null vector
    write_line("Null Vector: " + vector_to_string(my_vector_2));
    write_line("Null Vector Magnitude: " + to_string(vector_magnitude(my_vector_2)));
    write_line("Null Vector Normal: " + vector_to_string(my_vector_2_normal));
    write_line("Null Vector Normal Magnitude: " + to_string(vector_magnitude(my_vector_2_normal)));

    return 0;
}
