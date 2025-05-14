#include "splashkit.h"

int main()
{
    // Open a window with a descriptive name
    open_window("Point on line", 800, 600);

    // Define a horizontal line from point (100, 300) to (700, 300)
    point_2d start_point = point_at(100, 300);
    point_2d end_point = point_at(700, 300);
    line base_line = line_from(start_point, end_point);

    // Random hidden point on the line
    double hidden_x = rnd(100, 700);
    point_2d hidden_point = point_at(hidden_x, 300);

    // Run until the user closes the window
    while (!window_close_requested("Point on line"))
    {
        // Update mouse and keyboard input
        process_events();

        // Clear the screen before drawing
        clear_screen(COLOR_WHITE);

        // Draw the black line
        draw_line(COLOR_BLACK, base_line);

        // Get current mouse position
        point_2d mouse = mouse_position();

        // Check how close the mouse is to the hidden point
        if (point_point_distance(mouse, hidden_point) <= 8.0)
        {
            // User found the hidden point
            draw_circle(COLOR_BLUE, hidden_point.x, hidden_point.y, 5);
            draw_text("You found the hidden point!", COLOR_GREEN, 260, 450);
        }
        else if (point_on_line(mouse, base_line, 5.0f))
        {
            // Mouse is on the line, but not on the hidden point
            draw_text("You're on the line, but not on the hidden point.", COLOR_RED, 180, 450);
        }
        else
        {
            // Mouse is not on the line
            draw_text("Move your mouse over the line to find the hidden point!", COLOR_BLACK, 150, 450);
        }

        // Show the new frame
        refresh_screen(60);
    }

    // Close the window when done
    return 0;
}
