#include "splashkit.h"

int main()
{
    // Open a window titled "Falling Snow" with a size of 800x600
    open_window("Falling Snow", 800, 600);

    // Loop until the user requests to quit
    while (!quit_requested())
    {
        // Draw 100 random pixels on the window
        for (int i = 0; i < 100; i++)
        {
            draw_pixel_on_window(COLOR_GRAY, rnd(800), rnd(600));       
        // Refresh the screen to show the pixels
        refresh_screen();

        // Delay to control the frame rate 
        delay(50); 
        }     
        
    }
    // Close all windows
    close_all_windows;
    return 0;
}
