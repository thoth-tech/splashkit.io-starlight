#include "splashkit.h"

int main()
{
    // Create a rotation matrix for 45 degrees
    matrix_2d my_matrix_1;
    my_matrix_1 = rotation_matrix(45);

    // Print the rotation matrix to the console
    write_line("Rotation Matrix (90 degrees):");
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
