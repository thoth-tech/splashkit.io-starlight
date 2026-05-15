#include "splashkit.h"

int main()
{
    // Open a window to display the random colours
    open_window("Random Colour Grid", 640, 480);

    while (!quit_requested())
    {
        process_events();

        // Clear the screen before drawing
        clear_screen(color_white());

        // Draw a grid of squares with random colours
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                color random_colour = random_rgb_color(255);

                fill_rectangle(random_colour, 80 + col * 120, 80 + row * 80, 80, 50);
                draw_rectangle(color_black(), 80 + col * 120, 80 + row * 80, 80, 50);
            }
        }

        // Add a label to explain the example
        draw_text("Each square uses random_rgb_color()", color_black(), 150, 420);

        // Refresh the screen to show the updated colours
        refresh_screen(2);
    }

    // Close the window when the program ends
    close_all_windows();

    return 0;
}