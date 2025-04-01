#include "splashkit.h"

int main()
{
    // Sets the refresh rate at 60 frames per second
    const int fps = 60;
    
    const int width = 800;
    const int height = 600;
    
    // Create a window and make the background black
    window window = open_window("Usage Example - Draw Pixel On Window", width, height);
    clear_window(window, COLOR_BLACK);

    // Variables for the angle and radius of the spiral at any given time
    double angle = 0.0;
    double radius = 0.0;
    
    const double max_radius = width / 2;
    const point_2d center = point_at(width / 2, height / 2);

    while (!window_close_requested(window))
    {
        // Poll for user interaction
        process_events();
        
        // Stop drawing spiral once the width of the window is exceeded
        if (radius > max_radius) continue;
        
        // Increment spiral radius so it will reach window width in 30 seconds
        radius += max_radius / fps / 30;
        
        // Increment spiral angle so it will complete a cycle every 5 seconds
        angle += 360.0 / fps / 5;
        
        // Calculate the x and y coordinates of the pixel to be drawn
        double x = center.x + radius * cosine(angle);
        double y = center.y + radius * sine(angle);

        // Draws the next pixel of the spiral on the window
        draw_pixel_on_window(window, COLOR_YELLOW, x, y);
        refresh_window(window, fps);
    }

    // Clean up any resources or memory used by the window
    close_window(window);
}