#include "splashkit.h"
#include <vector>

int main()
{
    vector<line> lines;  // Vector to store the lines drawn by the user
    int line_end_x;      // X-coordinate for the end point of the line
    int line_start_x;    // X-coordinate for the start point of the line
    int line_start_y;    // Y-coordinate for the start point of the line
    int line_end_y;      // Y-coordinate for the end point of the line
    bool line_started = false;  // Flag to track if the user has started drawing a line

    // Open the window with dimensions 800x600
    open_window("Creating Lines With Mouse Input", 800, 600);

    // Main loop: runs until the program is quit
    while (!quit_requested())
    {
        process_events();  // Process user input events like mouse clicks

        // Check if the left mouse button was clicked
        if (mouse_clicked(LEFT_BUTTON))
        {
            // If the line hasn't been started, store the start point
            if (!line_started)
            {
                line_start_x = mouse_x();  // Get the X-coordinate of the mouse position
                line_start_y = mouse_y();  // Get the Y-coordinate of the mouse position
                line_started = true;       // Mark that the line has started
            }
            // If the line has started, store the end point and create the line
            else
            {
                line_end_x = mouse_x();    // Get the X-coordinate of the end point
                line_end_y = mouse_y();    // Get the Y-coordinate of the end point

                // Use `line_from` to create a line from the start point to the end point
                line temp_line = line_from(line_start_x, line_start_y, line_end_x, line_end_y);
                
                // Add the created line to the `lines` vector to store it
                lines.push_back(temp_line);
                line_started = false;  // Reset the flag to allow starting a new line
            }
        }

        clear_screen();  // Clear the screen to redraw everything
        // If the line has been started, show a temporary line being drawn
        if (line_started)
        {
            // Draw a temporary red line from the start point to the current mouse position
            draw_line(COLOR_RED, line_start_x, line_start_y, mouse_x(), mouse_y());
        }

        // Loop through the lines vector and draw each saved line
        for (int i = 0; i < lines.size(); i++)
        {
            // Draw each line in blue using the `draw_line` function
            draw_line(COLOR_BLUE, lines[i]);
        }

        // Display a message at the top of the screen
        draw_text("Click anywhere to start a line", COLOR_BLACK, 50, 50);

        // Refresh the screen to show the updated drawing
        refresh_screen();
    }

    return 0;  // End the program
}
