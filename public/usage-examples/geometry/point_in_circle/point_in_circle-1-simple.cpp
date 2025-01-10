#include "splashkit.h"

int main()
{
    open_window("Point In Circle", 800, 600);
    clear_screen();

    // Create a circle A
    circle A = circle_at(400, 300, 100);

    // Create a point 2d name mounse point
    point_2d MousePoint;

    while (!quit_requested())
    {
        process_events();

        // Set mouse point to the position of mouse
        MousePoint = mouse_position();

        // When mouse inside the circle show text "point in the circle!" and the color of the circle change to red
        if (point_in_circle(MousePoint, A))
        {
            clear_screen();
            draw_circle(COLOR_RED, A);
            string text = "Point in the Circle!";
            draw_text(text, COLOR_RED, 100, 100);
            refresh_screen();
        }
        // When mouse do not inside the circle show text "point not in the circle!" and the color of the circle change to green
        else
        {
            clear_screen();
            draw_circle(COLOR_GREEN, A);
            string text = "Point not in the Circle!";
            draw_text(text, COLOR_RED, 100, 100);
            refresh_screen();
        }
    }
    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}