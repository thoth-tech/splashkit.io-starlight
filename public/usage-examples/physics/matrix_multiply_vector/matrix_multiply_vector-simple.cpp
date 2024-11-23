#include "splashkit.h"

int main()
{
    // Define and populate the first matrix
    matrix_2d my_matrix_1;
    my_matrix_1.elements[0][0] = 1;
    my_matrix_1.elements[0][1] = 2;
    my_matrix_1.elements[0][2] = 3;

    my_matrix_1.elements[1][0] = 0;
    my_matrix_1.elements[1][1] = 1;
    my_matrix_1.elements[1][2] = 4;

    my_matrix_1.elements[2][0] = 5;
    my_matrix_1.elements[2][1] = 6;
    my_matrix_1.elements[2][2] = 0;

    // Define the second matrix as an identity matrix
    matrix_2d my_matrix_2;
    my_matrix_2 = identity_matrix();

    // Multiply the two matrices
    matrix_2d my_matrix_1_multiplied_by_matrix = matrix_multiply(my_matrix_1, my_matrix_2);

    // Print the matrices
    write_line(matrix_to_string(my_matrix_1));
    write_line(matrix_to_string(my_matrix_2));
    write_line(matrix_to_string(my_matrix_1_multiplied_by_matrix));

    return 0;
}
