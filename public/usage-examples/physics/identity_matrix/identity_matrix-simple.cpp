#include "splashkit.h"

int main()
{
    // Create an identity matrix
    matrix_2d my_matrix_1;
    my_matrix_1 = identity_matrix();

    // Print the matrix to the console
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
