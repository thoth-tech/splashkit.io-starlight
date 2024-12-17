#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Vector Visualisations", 300, 300);

    // Define rectangles
    rectangle test_rectangle_1 = {50, 200, 50, 50};
    rectangle test_rectangle_2 = {200, 200, 50, 50};
    rectangle test_rectangle_3 = {200, 50, 50, 50};

    // Define origin point
    point_2d origin = {0, 0};

    // Create vectors from origin to rectangles
    vector_2d my_vector_1 = vector_from_point_to_rect(origin, test_rectangle_1);
    vector_2d my_vector_2 = vector_from_point_to_rect(origin, test_rectangle_2);
    vector_2d my_vector_3 = vector_from_point_to_rect(origin, test_rectangle_3);

    // Clear the screen
    clear_screen();

    // Draw rectangles
    fill_rectangle(COLOR_RED, test_rectangle_1);
    fill_rectangle(COLOR_BLUE, test_rectangle_2);
    fill_rectangle(COLOR_PURPLE, test_rectangle_3);

    // Draw lines representing vectors
    draw_line(COLOR_BLACK, line_from(my_vector_1));
    draw_line(COLOR_ORANGE, line_from(my_vector_2));
    draw_line(COLOR_BROWN, line_from(my_vector_3));

    // Refresh the screen
    refresh_screen();

    // Wait and close the window
    delay(4000);
    close_all_windows();

    return 0;
}
