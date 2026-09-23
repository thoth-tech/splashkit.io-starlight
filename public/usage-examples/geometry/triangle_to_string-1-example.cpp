#include "splashkit.h"
#include <string>

int main()
{
    open_window("Triangle To String", 800, 600);

    // Create a triangle to describe
    triangle demo_triangle =
    {
        point_at(300, 200),
        point_at(500, 200),
        point_at(400, 400)
    };

    while (!quit_requested())
    {
        process_events();

        // Convert the triangle into a text description
        std::string triangle_text = triangle_to_string(demo_triangle);

        clear_screen(COLOR_WHITE);

        // Draw the triangle
        draw_triangle(COLOR_BLUE, demo_triangle);

        // Display the generated text
        draw_text("Triangle description:", COLOR_BLACK, 20, 20);
        draw_text(triangle_text, COLOR_BLACK, 20, 50);

        refresh_screen(60);
    }

    return 0;
}