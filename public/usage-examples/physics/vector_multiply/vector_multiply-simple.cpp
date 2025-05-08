#include "splashkit.h"

using std::to_string;

int main()
{
    // Define the vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    double vector_scale = 5;

    // Multiply the vector by a scalar value
    write_line("Multiply Vector by: " + to_string(vector_scale));
    vector_2d my_vector_1_multiplied = vector_multiply(my_vector_1, 5);

    // Output the original and multiplied vectors
    write_line(vector_to_string(my_vector_1));
    write_line("Vector multiplied by scaling value: " + vector_to_string(my_vector_1_multiplied));

    return 0;
}
