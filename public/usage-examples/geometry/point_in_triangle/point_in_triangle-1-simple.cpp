#include "splashkit.h"

int main()
{
    open_window("Point In triangle", 800, 600);
    clear_screen();

    // Create a triangle A
    triangle A = triangle_from(700, 200, 500, 1, 200, 500);

    // Create a point 2d name mounse point
    point_2d MousePoint;

    while (!quit_requested())
    {
        process_events();

        // Set mouse point to the position of mouse
        MousePoint = mouse_position();

        // When mouse inside the triangle show text "point in the triangle!" and the color of the triangle change to red
        if (point_in_triangle(MousePoint, A))
        {
            clear_screen();
            draw_triangle(COLOR_RED, A);
            string text = "Point in the triangle!";
            draw_text(text, COLOR_RED, 100, 100);
            refresh_screen();
        }
        // When mouse do not inside the triangle show text "point not in the triangle!" and the color of the triangle change to green
        else
        {
            clear_screen();
            draw_triangle(COLOR_GREEN, A);
            string text = "Point not in the triangle!";
            draw_text(text, COLOR_RED, 100, 100);
            refresh_screen();
        }
    }
    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}