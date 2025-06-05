#include "splashkit.h"

int main()
{

    open_window("Is the Circle inside the Quad?", 800, 600);

    // Define variables
    quad fixed_quad = quad_from(300, 100, 500, 200, 200, 400, 600, 500);
    color quad_color;
    string text;
    circle mouse_circle;

    while (!quit_requested())
    {
        process_events();

        // Update circle position to follow the mouse
        mouse_circle = circle_at(mouse_x(), mouse_y(), 30);

        // Check if circle is intersecting with quad
        if (circle_quad_intersect(mouse_circle, fixed_quad))
        {
            quad_color = COLOR_GREEN;
            text = "Yes, it is!";
        }
        else
        {
            quad_color = COLOR_RED;
            text = "No, it isn't...";
        }

        // Display the quad and circle
        clear_screen(COLOR_WHITE);
        fill_quad(quad_color, fixed_quad);
        draw_text(text, COLOR_BLACK, 330, 300);
        draw_circle(COLOR_BLACK, mouse_circle);
        refresh_screen();
    }

    close_all_windows();

    return 0;
}