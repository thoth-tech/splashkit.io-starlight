#include "splashkit.h"
#include <vector>

int main()
{
    // Open a graphical window with the given title and dimensions
    open_window("Lines From Rectangle Example", 800, 600);

    // Calculate coordinates to center the rectangle in the window
    float x = (800 - 300) / 2;
    float y = (600 - 200) / 2;

    // Create a rectangle at the calculated position with width 300 and height 200
    rectangle my_rect = rectangle_from(x, y, 300, 200);

    // Get the 4 edges of the rectangle as individual line segments
    vector<line> rect_edges = lines_from(my_rect);

    // Define colors to be used when the mouse is NOT hovering over an edge
    color normal_colors[4] = {
        COLOR_RED,         // Top
        COLOR_LIME_GREEN,  // Right
        COLOR_BLUE,        // Bottom
        COLOR_YELLOW       // Left
    };

    // Define colors to be used when the mouse IS hovering over an edge
    color hover_colors[4] = {
        COLOR_WHITE,
        COLOR_WHITE,
        COLOR_WHITE,
        COLOR_WHITE
    };

    // Main loop — runs until the user closes the window
    while (!window_close_requested("Lines From Rectangle Example"))
    {
        // Handle input and OS-level window events
        process_events();

        // Clear the screen with a dark background color
        clear_screen(COLOR_DARK_SLATE_GRAY);

        // Fill the rectangle area with black as the background
        fill_rectangle(COLOR_BLACK, my_rect);

        // Get the current position of the mouse
        point_2d mouse = mouse_position();

        // Loop through each of the 4 rectangle edges
        for (int i = 0; i < 4; i++)
        {
            // Check if the mouse is hovering over the current edge
            if (point_on_line(mouse, rect_edges[i]))
            {
                // Draw the edge using the hover color (white)
                draw_line(hover_colors[i], rect_edges[i]);
            }
            else
            {
                // Otherwise, draw the edge using its normal default color
                draw_line(normal_colors[i], rect_edges[i]);
            }
        }

        // Refresh the screen to render all drawings
        refresh_screen(60);

        // Optional: short delay to reduce CPU usage (10 milliseconds)
        delay(10);
    }

    return 0;
}