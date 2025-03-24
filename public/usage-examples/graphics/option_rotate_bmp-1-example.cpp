#include "splashkit.h"

int main()
{
    // Set the frame rate to 60 frames per second
    const int fps = 60;

    // Open a window with dimensions 800 x 600
    open_window("Usage Example - Option Rotate Bmp", 800, 600);

    // Create a bitmap with dimensions 300 x 300
    bitmap bmp = create_bitmap("box", 300, 300);

    // Draw a red box on the bitmap
    quad rect = quad_from(0, 0, 300, 0, 0, 300, 300, 300);
    fill_quad_on_bitmap(bmp, COLOR_RED, rect);

    // Initialize a float to hold the angle of the rotated bitmap
    float angle = 0;

    // Loop until the user exits
    while (!quit_requested())
    {
        // Poll for events caused by user interaction
        process_events();

        // Increment the angle of the box for the current frame.
        // This calculation will rotate the box 180 degrees every second.
        angle += 360 / 2 / fps;

        // Keep the angle between 0 and 360 degrees
        if (angle >= 360) angle -= 360;

        // Create the draw options that will rotate the bitmap
        drawing_options opts = option_rotate_bmp(angle);

        // Clear the previous frame and set the background to black
        clear_screen(COLOR_BLACK);

        // Draw the rotated bitmap at the center of the screen
        draw_bitmap(bmp, 250, 150, opts);

        // Refresh the screen to show the current frame.
        // Since the fps is 60, this will happen 60 times per second.
        refresh_screen(fps);
    }

    // Clean up by freeing any memory used by the windows
    close_all_windows();

    return 0;
}