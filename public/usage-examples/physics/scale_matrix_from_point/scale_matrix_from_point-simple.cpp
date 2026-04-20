#include "splashkit.h"

int main()
{
    // Define the scale factors
    point_2d matrix_scale;
    matrix_scale.x = 2.0;  // Scale width by 2
    matrix_scale.y = 1.0;  // Keep height unchanged

    // Create a scaling matrix using the scale factors
    matrix_2d scaling_matrix = scale_matrix(matrix_scale);

    // Print the scaling matrix to the console
    write_line("Scaling Matrix:");
    write_line(matrix_to_string(scaling_matrix));

    // Define a point to apply the scaling matrix
    point_2d original_point = {100, 50};
    write_line("Original Point: " + point_to_string(original_point));

    // Apply the scaling matrix to the point
    point_2d scaled_point = matrix_multiply(scaling_matrix, original_point);
    write_line("Scaled Point (after applying scaling matrix): " + point_to_string(scaled_point));

    return 0;
}
