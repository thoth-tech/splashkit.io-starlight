#include "splashkit.h"

int main() 
{
    // Open a window with the title "Rotate bitmap" and dimensions 800x600
    open_window("Rotate bitmap", 800, 600);

    // Load the bitmap for the clock hand from the file "clock_hand.png"
    bitmap clockwise = load_bitmap("Clock Hand", "clock_hand.png");

    // Load the bitmap for the clock face from the file "clock.png"
    bitmap clock = load_bitmap("Clock", "clock.png");

    // Loop to animate the rotation of the clock hand through 360 degrees
    for (int i = 0; i < 360; i++)
    {
        // Draw the clock hand bitmap rotated to the current angle (i degrees)
        draw_bitmap(clockwise, 100, 100, option_rotate_bmp(i));

        // Draw the clock face bitmap at the same position to keep it static
        draw_bitmap(clock, 100, 100);

        // Refresh the screen to update the display with the latest drawings
        refresh_screen();

        // Pause for 100 milliseconds to create a smooth animation effect
        delay(100);

        // Clear the screen to remove the previous frame before drawing the next one
        clear_screen();
    }

    // Free all loaded bitmap resources to prevent memory leaks
    free_all_bitmaps();

    // Close all open windows to end the program
    close_all_windows();

    return 0;
}
