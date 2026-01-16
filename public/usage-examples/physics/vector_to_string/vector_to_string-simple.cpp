#include "splashkit.h"

using std::to_string;

int main()
{
    // Define a vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Output the details of the vector
    write_line("Vector Details:");
    write_line("X: " + to_string(my_vector_1.x));
    write_line("Y: " + to_string(my_vector_1.y));
    write_line("Vector as String: " + vector_to_string(my_vector_1));

    return 0;
}
