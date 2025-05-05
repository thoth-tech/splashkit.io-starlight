#include "splashkit.h"

int main()
{
    // Open a window with a descriptive name
    open_window("Point on line", 800, 600);

    // Define a horizontal line from point (100, 300) to (700, 300)
    point_2d startPoint = point_at(100, 300);
    point_2d endPoint = point_at(700, 300);
    line baseLine = line_from(startPoint, endPoint);

    // Random hidden point on the line
    double hiddenX = rnd(100, 700);
    point_2d hiddenPoint = point_at(hiddenX, 300);

    // Run until the user closes the window
    while (!window_close_requested("Hover to Guess the Hidden Point"))
    {
        // Update mouse and keyboard input
        process_events();

        // Clear the screen before drawing
        clear_screen(COLOR_WHITE);

        // Draw the black line
        draw_line(COLOR_BLACK, baseLine);

        // Get current mouse position
        point_2d mouse = mouse_position();

        // Check how close the mouse is to the hidden point
        if (point_point_distance(mouse, hiddenPoint) <= 8.0)
        {
            // User found the hidden point
            draw_circle(COLOR_BLUE, hiddenPoint.x, hiddenPoint.y, 5);
            draw_text("You found the hidden point!", COLOR_GREEN, 260, 450);
        }
        else if (point_on_line(mouse, baseLine, 5.0f))
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

