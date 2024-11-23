#include "splashkit.h"

int main()
{
    // Define the scale factors
    point_2d matrix_scale;
    matrix_scale.x = 2;  // Scale width by 2
    matrix_scale.y = 1;  // Keep height unchanged

    // Create a scaling matrix using the scale factors
    matrix_2d my_matrix_1;
    my_matrix_1 = scale_matrix(matrix_scale);

    // Print the scaling matrix to the console
    write_line("Scaling Matrix:");
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
