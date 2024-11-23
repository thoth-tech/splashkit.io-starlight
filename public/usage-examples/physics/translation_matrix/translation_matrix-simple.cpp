#include "splashkit.h"

int main()
{
    // Define the translation values
    double translation_x = 200;
    double translation_y = 100;

    // Create a translation matrix using the translation values
    matrix_2d my_matrix_1 = translation_matrix(translation_x, translation_y);

    // Print the translation matrix to the console
    write_line("Translation Matrix:");
    write_line(matrix_to_string(my_matrix_1));

    // Define the original point
    point_2d original_point = {50, 50};
    write_line("Original Point: " + point_to_string(original_point));

    // Apply the translation to the point
    point_2d translated_point = matrix_multiply(my_matrix_1, original_point);
    write_line("Translated Point: " + point_to_string(translated_point));

    return 0;
}
