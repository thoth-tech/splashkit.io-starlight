#include "splashkit.h"

int main()
{
    // Define the translation point
    vector_2d matrix_translation;
    matrix_translation.x = 200;  // Shift right by 200 units
    matrix_translation.y = 100;  // Shift down by 100 units

    // Create a translation matrix using the translation point
    matrix_2d my_matrix_1 = translation_matrix(matrix_translation);

    // Print the translation matrix to the console
    write_line("Translation Matrix:");
    write_line(matrix_to_string(my_matrix_1));

    // Define the original point
    point_2d original_point = {50, 50};
    write_line("Original Point: " + point_to_string(original_point));

    // Apply the translation matrix to the point
    point_2d translated_point = matrix_multiply(my_matrix_1, original_point);
    write_line("Translated Point (after applying translation matrix): " + point_to_string(translated_point));

    return 0;
}
