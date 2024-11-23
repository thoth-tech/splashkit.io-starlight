#include "splashkit.h"

int main()
{
    // Create a rotation matrix for 45 degrees
    matrix_2d rotation_matrix_45 = rotation_matrix(45);

    // Print the rotation matrix to the console
    write_line("Rotation Matrix (45 degrees):");
    write_line(matrix_to_string(rotation_matrix_45));

    // Define a point
    point_2d original_point = {1, 0}; // A point on the x-axis
    write_line("Original Point:");
    write_line(point_to_string(original_point));

    // Apply the rotation matrix to the point
    point_2d rotated_point = matrix_multiply(rotation_matrix_45, original_point);
    write_line("Rotated Point (after 45-degree rotation):");
    write_line(point_to_string(rotated_point));

    return 0;
}
