#include "splashkit.h"

int main()
{
    // Open a window for visualization
    open_window("Transformation Matrix Visualization", 400, 400);
    clear_screen(COLOR_WHITE);

    // Define the scaling factors
    point_2d matrix_scale;
    matrix_scale.x = 1.5;  // Scale width by 1.5
    matrix_scale.y = 1.2;  // Scale height by 1.2

    // Define the translation (shift by a small amount)
    point_2d matrix_translation;
    matrix_translation.x = 20;  // Shift right by 20 units
    matrix_translation.y = -30; // Shift up by 30 units

    // Define the rotation angle
    double rotation = 45;

    // Create a matrix combining scaling, rotation, and translation
    matrix_2d transformation_matrix = scale_rotate_translate_matrix(matrix_scale, rotation, matrix_translation);

    // Define the original triangle points (centered and larger)
    triangle original_triangle;
    original_triangle.points[0] = {200, 150};  // Top point
    original_triangle.points[1] = {150, 250};  // Bottom-left point
    original_triangle.points[2] = {250, 250};  // Bottom-right point

    // Draw the original triangle
    fill_triangle(COLOR_BLUE, original_triangle);
    write_line("Original (Blue) Triangle Points:");
    for (int i = 0; i < 3; i++)
        write_line(point_to_string(original_triangle.points[i]));

    // Transform the triangle using the transformation matrix
    apply_matrix(transformation_matrix, original_triangle);

    // Draw the transformed triangle
    fill_triangle(COLOR_RED, original_triangle);
    write_line("Transformed (Red) Triangle Points:");
    for (int i = 0; i < 3; i++)
        write_line(point_to_string(original_triangle.points[i]));

    // Refresh the screen
    refresh_screen();
    delay(5000);

    close_all_windows();

    return 0;
}
