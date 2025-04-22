#include "splashkit.h"

int main()
{
    // Open a new window titled "Fill Ellipse Example" with dimensions 800x600
    open_window("Fill Ellipse Example", 800, 600);

    // Clear the screen with white color
    clear_screen(COLOR_WHITE);

    // Fill a blue ellipse at position (200, 200) with width 400 and height 200
    fill_ellipse(COLOR_BLUE, 200, 200, 400, 200);

    // Draw a red rectangle outline over the ellipse
    draw_rectangle(COLOR_RED, 200, 200, 400, 200);

    // Refresh the screen to display the drawings
    refresh_screen();

    // Wait for 4 seconds before closing the window
    delay(4000);

    // Close all open windows
    close_all_windows();

    return 0;
}
