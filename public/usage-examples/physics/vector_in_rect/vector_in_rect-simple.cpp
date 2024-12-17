#include "splashkit.h"

int main()
{
    // Open a window for visualisation
    open_window("Vector Visualisations", 300, 300);

    // Define the rectangle
    rectangle test_rectangle_1;
    test_rectangle_1.x = 50;
    test_rectangle_1.y = 50;
    test_rectangle_1.width = 200;
    test_rectangle_1.height = 200;

    // Define two vectors using angles and magnitudes
    vector_2d my_vector_1 = vector_from_angle(45, 200);
    vector_2d my_vector_2 = vector_from_angle(10, 200);

    // Clear the screen
    clear_screen();

    // Draw the rectangle and the vectors
    fill_rectangle(COLOR_BLACK, test_rectangle_1);
    draw_line(COLOR_RED, line_from(my_vector_1));
    draw_line(COLOR_BLUE, line_from(my_vector_2));

    // Check if vectors are inside the rectangle
    if (vector_in_rect(my_vector_1, test_rectangle_1))
        write_line("Red vector in rectangle!");
    if (vector_in_rect(my_vector_2, test_rectangle_1))
        write_line("Blue vector in rectangle!");

    // Refresh the screen and wait
    refresh_screen();
    delay(4000);

    // Close all windows
    close_all_windows();

    return 0;
}
