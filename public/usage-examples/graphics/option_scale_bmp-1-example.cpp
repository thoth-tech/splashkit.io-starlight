#include "splashkit.h"

int main()
{
    // Set frame rate to 60 frames per second
    const int fps = 60;

    // Create a window with dimensions 800 x 600
    window window = open_window("Usage Example - Option Scale Bitmap", 800, 600);

    // Create a bitmap called 'ring' with dimensions 600 x 600
    bitmap bmp = create_bitmap("ring", 600, 600);

    // Paint the bitmap background black
    clear_bitmap(bmp, COLOR_BLACK);

    // Draw a ring on the bitmap
    fill_circle_on_bitmap(bmp, COLOR_WHITE, 300, 300, 300);
    fill_circle_on_bitmap(bmp, COLOR_BLACK, 300, 300, 200);

    // Initialize the time to 0
    double time = 0;

    // Loop until the user closes the window
    while (!window_close_requested(window))
    {
        // Poll for user interactions
        process_events();

        // Increment the time by the duration of a frame
        time += 1.0 / fps;

        // Calculate the scale factor by squaring the time
        double scale_factor = time * time;

        // If the bitmap is over 2.5 times its initial size, then reset the time
        if (scale_factor > 2.5) time = 0;

        // Create the draw options that will scale the bitmap
        drawing_options opts = option_scale_bmp(scale_factor, scale_factor);

        // Draw the scaled bitmap onto the window and refresh
        clear_window(window, COLOR_BLACK);
        draw_bitmap_on_window(window, bmp, 100, 0, opts);
        refresh_window(window, fps);
    }

    // Clean up any memory or resources being used by the window
    close_window(window);
    return 0;
}