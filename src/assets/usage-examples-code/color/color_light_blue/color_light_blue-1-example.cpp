#include "splashkit.h"

int main()
{
    // Define the color Light Blue
    color my_color = COLOR_LIGHT_BLUE;

    // Open a window
    open_window("Light Blue Example", 400, 400);

    // Draw a filled circle on the screen using the color from above
    clear_screen();
    fill_circle(my_color, 200, 200, 100);
    refresh_screen();

    // Keep the window open for 5 seconds
    delay(5000);

    // Close the window
    close_window("Light Blue Example");

    return 0;
}
