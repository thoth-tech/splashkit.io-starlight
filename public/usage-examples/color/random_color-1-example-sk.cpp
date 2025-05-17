#include "splashkit.h"

int main()
{
    open_window("Random Color", 800, 600);

    // Store the original and current color
    color originalColor = random_color();
    color currentColor = originalColor;

    while (!window_close_requested("Random Color"))
    {
        // Process user input events
        process_events();

        // Left click: change to a new random color
        if (mouse_clicked(LEFT_BUTTON))
        {
            currentColor = random_color();
        }
        // Right click: return to original color
        else if (mouse_clicked(RIGHT_BUTTON))
        {
            currentColor = originalColor;
        }
        
        clear_screen(currentColor);
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
