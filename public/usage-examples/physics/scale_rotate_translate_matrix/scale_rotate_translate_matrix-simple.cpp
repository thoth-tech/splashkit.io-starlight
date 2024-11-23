#include "splashkit.h"

int main()
{
    // Define the scaling factors
    point_2d matrix_scale;
    matrix_scale.x = 2;  // Scale width by 2
    matrix_scale.y = 1;  // Scale height by 1 (no change)

    // Define the translation (shift by a small amount)
    point_2d matrix_translation;
    matrix_translation.x = 10;  // Shift right by 10 units
    matrix_translation.y = 5;   // Shift down by 5 units

    // Define the rotation angle
    double rotation = 45;

    // Create a matrix combining scaling, rotation, and translation
    matrix_2d my_matrix_1;
    my_matrix_1 = scale_rotate_translate_matrix(matrix_scale, rotation, matrix_translation);

    // Print the resulting matrix to the console
    write_line("Resulting Transformation Matrix:");
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
