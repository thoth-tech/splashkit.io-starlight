#include "splashkit.h"

int main()
{
    // Define the translation values
    double translation_x = 200;
    double translation_y = 100;

    // Create a translation matrix using the translation values
    matrix_2d my_matrix_1;
    my_matrix_1 = translation_matrix(translation_x, translation_y);

    // Print the translation matrix to the console
    write_line(matrix_to_string(my_matrix_1));

    return 0;
}
