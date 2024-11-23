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

    // Calculate the dot product
    double vector_dot_product = dot_product(my_vector_1, my_vector_2);

    // Output vector details and the dot product
    write_line(vector_to_string(my_vector_1));
    write_line(vector_to_string(my_vector_2));
    write_line(vector_dot_product);

    return 0;
}
