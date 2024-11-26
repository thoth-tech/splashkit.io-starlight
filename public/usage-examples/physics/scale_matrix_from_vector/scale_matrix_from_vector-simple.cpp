#include "splashkit.h"

int main()
{
    // Define the scale factors
    vector_2d matrix_scale;
    matrix_scale.x = 2.0; // Scale width by 2
    matrix_scale.y = 1.0; // Keep height unchanged

    // Create a scaling matrix using the scale factors
    matrix_2d scaling_matrix = scale_matrix(matrix_scale);

    // Print the scaling matrix to the console
    write_line("Scaling Matrix:");
    write_line(matrix_to_string(scaling_matrix));

    // Define a vector to demonstrate the scaling
    vector_2d original_vector = {100, 50};
    write_line("Original Vector: " + vector_to_string(original_vector));

    // Apply the scaling matrix to the vector
    vector_2d scaled_vector = matrix_multiply(scaling_matrix, original_vector);
    write_line("Scaled Vector (after applying scaling matrix): " + vector_to_string(scaled_vector));

    return 0;
}
