#include "splashkit.h"

int main()
{
    // Open a 300x300 window
    window window = open_window("Vector Offset Lines", 300, 300);
    // Use the center of the window as the start point for lines
    point_2d start = point_at(150, 150);
    // Create vectors for up and right
    vector_2d vec_up = vector_2d{0.0, -100.0};
    vector_2d vec_right = vector_2d{100.0, 0.0};

    while (!window_close_requested(window))
    {
        process_events();
        clear_screen();
        // Draw a red line with the up vector as offset
        draw_line(COLOR_RED, line_from(start, vec_up));
        // Draw a blue line with the right vector as offset
        draw_line(COLOR_BLUE, line_from(start, vec_right));
        refresh_screen();
    }
    close_all_windows();
    return 0;
}