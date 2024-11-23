#include "splashkit.h"

int main()
{
    // Define the translation vector
    vector_2d matrix_translation;
    matrix_translation.x = 200;
    matrix_translation.y = 100;

    // Create a translation matrix using the translation vector
    matrix_2d my_matrix_1;
    my_matrix_1 = translation_matrix(matrix_translation);

    // Print the translation matrix to the console
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
