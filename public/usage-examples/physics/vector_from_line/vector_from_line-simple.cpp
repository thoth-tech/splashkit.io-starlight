#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Define points for lines
    point_2d origin = {150, 150};
    point_2d line_1_end = {173, 221};
    point_2d line_2_end = {90, 194};
    point_2d line_3_end = {90, 106};
    point_2d line_4_end = {173, 79};
    point_2d line_5_end = {225, 150};

    // Create lines
    line line_1 = line_from(origin, line_1_end);
    line line_2 = line_from(origin, line_2_end);
    line line_3 = line_from(origin, line_3_end);
    line line_4 = line_from(origin, line_4_end);
    line line_5 = line_from(origin, line_5_end);

    // Convert lines to vectors
    vector_2d my_vector_1 = vector_from_line(line_1);
    vector_2d my_vector_2 = vector_from_line(line_2);
    vector_2d my_vector_3 = vector_from_line(line_3);
    vector_2d my_vector_4 = vector_from_line(line_4);
    vector_2d my_vector_5 = vector_from_line(line_5);

    // Clear the screen
    clear_screen();

    // Output the vector details
    write_line("Vector 1: " + vector_to_string(my_vector_1));
    write_line("Vector 2: " + vector_to_string(my_vector_2));
    write_line("Vector 3: " + vector_to_string(my_vector_3));
    write_line("Vector 4: " + vector_to_string(my_vector_4));
    write_line("Vector 5: " + vector_to_string(my_vector_5));

    // Draw lines
    draw_line(COLOR_BLUE, line_1);
    draw_line(COLOR_RED, line_2);
    draw_line(COLOR_BLACK, line_3);
    draw_line(COLOR_PURPLE, line_4);
    draw_line(COLOR_ORANGE, line_5);

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
