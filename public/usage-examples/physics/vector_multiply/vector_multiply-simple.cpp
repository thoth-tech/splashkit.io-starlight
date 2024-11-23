#include "splashkit.h"

int main()
{
    // Define the vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Multiply the vector by a scalar value
    vector_2d my_vector_1_multiplied = vector_multiply(my_vector_1, 5);

    // Output the original and multiplied vectors
    write_line(vector_to_string(my_vector_1));
    write_line(vector_to_string(my_vector_1_multiplied));

    return 0;
}
