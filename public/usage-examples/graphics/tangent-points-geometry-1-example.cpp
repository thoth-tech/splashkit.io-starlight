#include "splashkit.h"

int main()
{
    open_window("Tangent Points Calculation", 800, 600);

    // Create the circle at (400, 300) with radius 100
    circle circle = circle_at(point_at(400, 300), 100);
    point_2d cursor_pos; // Mouse position (the external point)
    point_2d tangent1, tangent2;

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();

        clear_screen();

        // Draw the circle
        draw_circle(color_black(), circle);

        // Draw the external point (mouse)
        fill_circle(color_blue(), cursor_pos.x, cursor_pos.y, 5);

        // Display mouse coordinates
        draw_text("Mouse Position (External Point): (" + std::to_string((int)cursor_pos.x) + ", " + std::to_string((int)cursor_pos.y) + ")", 
                  color_black(), "Arial", 16, 10, 10);

        // Calculate and draw tangent points if the mouse is outside the circle
        if (tangent_points(cursor_pos, circle, tangent1, tangent2))
        {
            fill_circle(color_red(), tangent1.x, tangent1.y, 5);
            fill_circle(color_red(), tangent2.x, tangent2.y, 5);
            draw_line(color_green(), cursor_pos, tangent1);
            draw_line(color_green(), cursor_pos, tangent2);

            // Show tangent point coordinates
            draw_text("Tangent 1: (" + std::to_string((int)tangent1.x) + ", " + std::to_string((int)tangent1.y) + ")",
                      color_black(), "Arial", 16, 10, 35);
            draw_text("Tangent 2: (" + std::to_string((int)tangent2.x) + ", " + std::to_string((int)tangent2.y) + ")",
                      color_black(), "Arial", 16, 10, 60);
        }
        else
        {
            draw_text("Move the mouse outside the circle to see tangent points.",
                      color_black(), "Arial", 16, 10, 35);
        }

        refresh_screen();
    }

    close_all_windows();
    return 0;
}
