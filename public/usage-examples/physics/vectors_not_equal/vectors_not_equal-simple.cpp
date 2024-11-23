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

    // Define the third vector
    vector_2d my_vector_3;
    my_vector_3.x = 200;
    my_vector_3.y = 100;

    // Check if vectors are equal
    if (vectors_not_equal(my_vector_1, my_vector_2))
        write_line("Vectors 1 and 2 are not equal.");
    else
        write_line("Vectors 1 and 2 are equal.");

    if (vectors_not_equal(my_vector_1, my_vector_3))
        write_line("Vectors 1 and 3 are not equal.");
    else
        write_line("Vectors 1 and 3 are equal.");

    if (vectors_not_equal(my_vector_2, my_vector_3))
        write_line("Vectors 2 and 3 are not equal.");
    else
        write_line("Vectors 2 and 3 are equal.");

    return 0;
}
