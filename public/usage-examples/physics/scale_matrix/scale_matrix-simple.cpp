#include "splashkit.h"

int main()
{
    // Define the uniform scaling factor
    double matrix_scale = 2;

    // Create a scaling matrix using the uniform scaling factor
    matrix_2d my_matrix_1;
    my_matrix_1 = scale_matrix(matrix_scale);

    // Print the scaling matrix to the console
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
