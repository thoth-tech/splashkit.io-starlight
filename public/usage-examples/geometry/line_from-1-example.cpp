#include "splashkit.h"

int main()
{
    // Open window
    window window = open_window("Basic Line Drawing", 300, 300);
    // Initialise start and end points for line
    point_2d start = point_at_origin();
    point_2d end = point_at_origin();
    
    while (!window_close_requested(window))
    {
        process_events();
        // Get start point from cursor on left click and end point on right click
        if (mouse_clicked(LEFT_BUTTON))
        {
            start = mouse_position();
        }
        else if (mouse_clicked(RIGHT_BUTTON))
        {
            end = mouse_position();
        }
        // Create a line between the points
        line line = line_from(start, end);
        // Draw the line in red
        clear_screen();
        draw_line(COLOR_RED, line);
        refresh_screen();
    }
    
    close_all_windows();
    return 0;
}