#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Apply Matrix to Triangle", 300, 300);

    // Clear the screen
    clear_screen(COLOR_WHITE);

    // Define the triangle points
    triangle test_triangle_1;
    point_2d top = {150, 150};
    point_2d left = {80, 220};
    point_2d right = {220, 220};

    test_triangle_1.points[0] = top;
    test_triangle_1.points[1] = left;
    test_triangle_1.points[2] = right;

    // Define the transformation matrix (scaling + translation)
    matrix_2d scaling_matrix = scale_matrix(0.5);
    matrix_2d trans_matrix = translation_matrix(-25, 50);
    matrix_2d my_matrix_1 = matrix_multiply(scaling_matrix, trans_matrix);

    // Draw the initial triangle
    fill_triangle(COLOR_BLACK, test_triangle_1);
    write_line("Triangle points before matrix application:");
    for (int i = 0; i < 3; i++)
        write_line(point_to_string(test_triangle_1.points[i]));

    // Apply the matrix to the triangle
    apply_matrix(my_matrix_1, test_triangle_1);

    // Draw the transformed triangle
    fill_triangle(COLOR_RED, test_triangle_1);
    write_line("Triangle points after matrix application:");
    for (int i = 0; i < 3; i++)
        write_line(point_to_string(test_triangle_1.points[i]));

    // Refresh the screen and wait
    refresh_screen();
    delay(4000);

    // Close all windows
    close_all_windows();

    return 0;
}
