#include "splashkit.h"
#include <string>

int main()
{
    open_window("Dot Product of Vectors", 800, 600);

    // Use one shared starting point for both vectors
    point_2d origin = point_at(400, 300);

    // Create two vectors with different directions
    vector_2d first_vector = vector_to(150, -100);
    vector_2d second_vector = vector_to(200, 80);

    while (!quit_requested())
    {
        process_events();

        // Calculate the dot product of the two vectors
        double result = dot_product(first_vector, second_vector);

        clear_screen(COLOR_WHITE);

        // Draw both vectors from the same origin point
        draw_line(COLOR_BLUE, origin.x, origin.y, origin.x + first_vector.x, origin.y + first_vector.y);
        draw_line(COLOR_RED, origin.x, origin.y, origin.x + second_vector.x, origin.y + second_vector.y);

        // Label the vectors and show the dot product value
        draw_text("Blue vector", COLOR_BLUE, 520, 180);
        draw_text("Red vector", COLOR_RED, 560, 390);
        draw_text("Dot product: " + std::to_string(result), COLOR_BLACK, 260, 40);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}