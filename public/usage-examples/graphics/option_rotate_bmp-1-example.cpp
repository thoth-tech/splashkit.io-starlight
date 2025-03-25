#include "splashkit.h"

int main()
{
    // Set the frame rate to 60 frames per second
    const int fps = 60;

    // Open a window with dimensions 800 x 600
    window window = open_window("Usage Example - Option Rotate Bmp", 800, 600);

    // Create a bitmap with dimensions 300 x 300
    bitmap bmp = create_bitmap("box", 300, 300);

    // Draw a red box on the bitmap
    quad rect = quad_from(0, 0, 300, 0, 0, 300, 300, 300);
    fill_quad_on_bitmap(bmp, COLOR_RED, rect);

    // Initialize a double to hold the angle of the rotated bitmap
    double angle = 0;

    // Loop until the user exits
    while (!window_close_requested(window))
    {
        // Poll for events caused by user interaction
        process_events();

        // Rotate the box 180 degrees every second
        angle += 360 / 2 / fps;

        // Create the draw options that will rotate the bitmap
        drawing_options opts = option_rotate_bmp(angle);

        // Clear the previous frame and set the background to black
        clear_window(window, COLOR_BLACK);

        // Draw the rotated bitmap at the center of the screen
        draw_bitmap_on_window(window, bmp, 250, 150, opts);
        refresh_window(window, fps);
    }

    // Clean up by freeing any memory used by the window
    close_window(window);
    return 0;
}
