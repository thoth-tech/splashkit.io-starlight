#include "splashkit.h"

int main()
{
    // Create a vector pointing to the specified coordinates
    vector_2d my_vector_1 = vector_to(200, 100);

    // Output the vector
    write_line("my_vector_1 values: " + vector_to_string(my_vector_1));

    return 0;
}
