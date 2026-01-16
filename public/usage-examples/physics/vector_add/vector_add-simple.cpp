#include "splashkit.h"

int main()
{
    // Define the first vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Define the second vector
    vector_2d my_vector_2;
    my_vector_2.x = -300;
    my_vector_2.y = 150;

    // Add the vectors
    vector_2d my_vector_3 = vector_add(my_vector_1, my_vector_2);

    // Output vector details and the result
    write_line("Vector 1: " + vector_to_string(my_vector_1));
    write_line("Vector 2: " + vector_to_string(my_vector_2));
    write_line("Vector 1 + 2: " + vector_to_string(my_vector_3));

    return 0;
}
