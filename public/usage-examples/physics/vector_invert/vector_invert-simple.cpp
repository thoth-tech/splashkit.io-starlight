#include "splashkit.h"

int main()
{
    // Define a vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Invert the vector
    vector_2d my_vector_1_inverted = vector_invert(my_vector_1);

    // Output the original and inverted vectors
    write_line("My Vector: " + vector_to_string(my_vector_1));
    write_line("My Inverted Vector: " + vector_to_string(my_vector_1_inverted));

    return 0;
}
