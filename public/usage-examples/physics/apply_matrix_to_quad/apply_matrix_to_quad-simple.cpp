#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Apply Matrix", 400, 400);

    // Clear the screen
    clear_screen(COLOR_WHITE);

    // Define the quad points
    quad test_rectangle_1;
    point_2d top_left = {150, 150};
    point_2d top_right = {250, 150};
    point_2d bottom_left = {150, 250};
    point_2d bottom_right = {250, 250};

    test_rectangle_1.points[0] = top_left;
    test_rectangle_1.points[1] = top_right;
    test_rectangle_1.points[2] = bottom_left;
    test_rectangle_1.points[3] = bottom_right;

    // Define the transformation matrix (scaling + translation)
    matrix_2d scaling_matrix = scale_matrix(0.5);
    matrix_2d trans_matrix = translation_matrix(50, 50);
    matrix_2d my_matrix_1 = matrix_multiply(scaling_matrix, trans_matrix);

    // Draw the initial quad
    fill_quad(COLOR_BLACK, test_rectangle_1);
    write_line("Quad points before matrix application:");
    for (int i = 0; i < 4; i++)
        write_line(point_to_string(test_rectangle_1.points[i]));

    // Apply the matrix to the quad
    apply_matrix(my_matrix_1, test_rectangle_1);

    // Draw the transformed quad
    fill_quad(COLOR_RED, test_rectangle_1);
    write_line("Quad points after matrix application:");
    for (int i = 0; i < 4; i++)
        write_line(point_to_string(test_rectangle_1.points[i]));

    // Refresh the screen and wait
    refresh_screen();
    delay(4000);

    // Close all windows
    close_all_windows();

    return 0;
}
