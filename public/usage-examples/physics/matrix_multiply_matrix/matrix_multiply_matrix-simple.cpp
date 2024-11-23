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

    // Define and populate the second matrix
    matrix_2d my_matrix_2;
    my_matrix_2.elements[0][0] = 7;
    my_matrix_2.elements[0][1] = 8;
    my_matrix_2.elements[0][2] = 9;

    my_matrix_2.elements[1][0] = 1;
    my_matrix_2.elements[1][1] = 0;
    my_matrix_2.elements[1][2] = 2;

    my_matrix_2.elements[2][0] = 3;
    my_matrix_2.elements[2][1] = 4;
    my_matrix_2.elements[2][2] = 5;

    // Multiply the two matrices
    matrix_2d result_matrix = matrix_multiply(my_matrix_1, my_matrix_2);

    // Print the original matrices and the result
    write_line("Matrix 1:");
    write_line(matrix_to_string(my_matrix_1));

    write_line("Matrix 2:");
    write_line(matrix_to_string(my_matrix_2));

    write_line("Resulting Matrix (Matrix 1 x Matrix 2):");
    write_line(matrix_to_string(result_matrix));

    return 0;
}
