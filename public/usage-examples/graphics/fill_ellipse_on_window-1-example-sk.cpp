#include "splashkit.h"

int main()
{
    // Open a new window
    window window = open_window("Ellipse Painter", 800, 600);
    clear_screen();

    // While user doesn't request to quit window
    while (!window_close_requested(window))
    {
        process_events();
        draw_text("Press on the C key to clear screen", color_black(), 5, 10);

        // If mouse clicked or held down get mouse position
        if (mouse_clicked(LEFT_BUTTON) || mouse_down(LEFT_BUTTON))
        {
            point_2d pos = mouse_position();

            // Fill ellipse in the position with random color
            fill_ellipse_on_window(window, random_color(), pos.x, pos.y, 100, 50);
        }

        // Clear screen if C key is pressed 
        if (key_typed(C_KEY))
        {
            clear_screen();
        }

        refresh_screen(60);
    }

    // Close all windows
    close_all_windows();
    return 0;
}