#include "splashkit.h"

int main()
{
    // Define the uniform scaling factor
    double scaling_factor = 2.0;

    // Create a scaling matrix using the uniform scaling factor
    matrix_2d scaling_matrix = scale_matrix(scaling_factor);

    // Print the scaling matrix to the console
    write_line("Scaling Matrix (Uniform Scaling by factor of 2):");
    write_line(matrix_to_string(scaling_matrix));

    // Define a point
    point_2d original_point = {100, 50};
    write_line("Original Point:");
    write_line(point_to_string(original_point));

    // Apply the scaling matrix to the point
    point_2d scaled_point = matrix_multiply(scaling_matrix, original_point);
    write_line("Scaled Point (after scaling by factor of 2):");
    write_line(point_to_string(scaled_point));

    return 0;
}
