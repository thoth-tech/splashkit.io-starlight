#include "splashkit.h"

int main()
{
    // Define and populate the matrix
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

    // Print the matrix
    write_line("Matrix:");
    write_line(matrix_to_string(my_matrix_1));

    // Define the vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Print the vector
    write_line("Original Vector:");
    write_line(vector_to_string(my_vector_1));

    // Multiply the matrix by the vector
    vector_2d result_vector = matrix_multiply(my_matrix_1, my_vector_1);

    // Print the resulting vector
    write_line("Transformed Vector:");
    write_line(vector_to_string(result_vector));

    return 0;
}
