#include "splashkit.h"

int main()
{
    // Declare constants
    const int FPS = 60;     // Set frame rate to 60 frames per second
    
    const int WINDOW_WIDTH = 800;
    const int WINDOW_HEIGHT = 600;

    const int WINDOW_X_POS = (display_width(display_details(0)) - 2 * WINDOW_WIDTH) / 2;
    const int WINDOW_Y_POS = (display_height(display_details(0)) - WINDOW_HEIGHT) / 2;

    const double MAX_RADIUS = WINDOW_HEIGHT * 3.0 / 8;

    // Declare variables
    double angle = 0.0;
    double radius = 0.0;

    // Open two windows with black backgrounds and position them side by side at center screen
    window window_left = open_window("Left Window - Pink Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);
    window window_right = open_window("Right Window - Blue Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);

    clear_window(window_left, COLOR_BLACK);
    clear_window(window_right, COLOR_BLACK);

    move_window_to(window_left, WINDOW_X_POS, WINDOW_Y_POS);
    move_window_to(window_right, WINDOW_X_POS + WINDOW_WIDTH, WINDOW_Y_POS);

    while (!window_close_requested(window_left) && !window_close_requested(window_right))
    {
        process_events();

        // Stop drawing when max radius is exceeded
        if (radius > MAX_RADIUS)
        {
            continue;
        }

        // Increment the radius and angle of the next pixel, and calculate the x-y coordinates
        radius += MAX_RADIUS / FPS / 60;
        angle += 360.0 / FPS / 15;

        double x = WINDOW_WIDTH / 2 + radius * cosine(angle);
        double y = WINDOW_HEIGHT / 2 + radius * sine(angle);

        // Draw the pixel on each window and refresh
        draw_pixel_on_window(window_left, COLOR_HOT_PINK, x, y);
        draw_pixel_on_window(window_right, COLOR_CYAN, x, y);
        refresh_screen(FPS);
    }

    // Clean up
    close_all_windows();
}