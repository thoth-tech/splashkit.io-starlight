#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Create vectors from angles
    vector_2d my_vector_1 = vector_from_angle(15, 250);
    vector_2d my_vector_2 = vector_from_angle(30, 250);
    vector_2d my_vector_3 = vector_from_angle(45, 250);
    vector_2d my_vector_4 = vector_from_angle(60, 250);
    vector_2d my_vector_5 = vector_from_angle(75, 250);

    // Clear the screen
    clear_screen();

    // Output the vector details
    write_line("Vector 1: " + vector_to_string(my_vector_1));
    write_line("Vector 2: " + vector_to_string(my_vector_2));
    write_line("Vector 3: " + vector_to_string(my_vector_3));
    write_line("Vector 4: " + vector_to_string(my_vector_4));
    write_line("Vector 5: " + vector_to_string(my_vector_5));

    // Draw lines representing the vectors
    draw_line(COLOR_BLUE, line_from(my_vector_1));
    draw_line(COLOR_RED, line_from(my_vector_2));
    draw_line(COLOR_BLACK, line_from(my_vector_3));
    draw_line(COLOR_PURPLE, line_from(my_vector_4));
    draw_line(COLOR_ORANGE, line_from(my_vector_5));

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
