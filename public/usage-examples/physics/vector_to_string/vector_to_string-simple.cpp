#include "splashkit.h"

int main()
{
    // Define a vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Output the vector
    write_line(vector_to_string(my_vector_1));

    return 0;
}
