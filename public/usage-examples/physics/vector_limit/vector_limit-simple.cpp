#include "splashkit.h"

int main()
{
    // Define a vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Limit the vector magnitude to 10
    vector_2d my_vector_1_limited = vector_limit(my_vector_1, 10);

    // Output the original and limited vectors
  	write("My Vector: ");
    write_line(vector_to_string(my_vector_1));
  	write("My Limited Vector: ");
    write_line(vector_to_string(my_vector_1_limited));

    return 0;
}
