#include "splashkit.h"

int main()
{
    // Access the first display
    display display = display_details(0);

    // Set the refresh rate to 60 frames per second
    const int fps = 60;

    const int window_width = 800;
    const int window_height = 600;

    // Calculate the position of the first window
    const int window_position_x = (display_width(display) - 2 * window_width) / 2;
    const int window_position_y = (display_height(display) - window_height) / 2;

    // Open two windows with black backgrounds
    window window_one = open_window("Window 1 - Draw Pixel On Window", window_width, window_height);
    window window_two = open_window("Window 2 - Draw Pixel On Window", window_width, window_height);
    clear_window(window_one, COLOR_BLACK);
    clear_window(window_two, COLOR_BLACK);

    // Position the windows side by side in the middle of the display
    move_window_to(window_one, window_position_x, window_position_y);
    move_window_to(window_two, window_position_x + window_width, window_position_y);

    // Store the angle and radius of the spiral at any given time
    double angle = 0.0;
    double radius = 0.0;

    const double max_radius = window_width / 2;

    // Coordinates for the center of the spiral
    const point_2d center = point_at(window_width / 2, window_height / 2);

    while (!window_close_requested(window_one) && !window_close_requested(window_two))
    {
        // Poll for user interaction
        process_events();

        // Stop drawing spiral once the width of the window is exceeded
        if (radius > max_radius) continue;

        // Increment spiral radius so it will reach window width in 30 seconds
        radius += max_radius / fps / 30;

        // Increment spiral angle so it will complete a revolution every 5 seconds
        angle += 360.0 / fps / 5;

        // Calculate the x and y coordinates of the pixel to be drawn
        double x = center.x + radius * cosine(angle);
        double y = center.y + radius * sine(angle);

        // Draw the next pixel of the spiral on both windows
        draw_pixel_on_window(window_one, COLOR_YELLOW, x, y);
        draw_pixel_on_window(window_two, COLOR_RED, x, y);

        refresh_screen(fps);
    }

    // Clean up any resources or memory used by the windows
    close_all_windows();
}