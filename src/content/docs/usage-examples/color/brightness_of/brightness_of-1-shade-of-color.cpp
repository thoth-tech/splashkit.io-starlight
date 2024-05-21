#include "splashkit.h"

using std::to_string;

int main()
{
    // Define a color (A shade of color)
    color my_color = rgba_color(100, 100, 200, 255); // A shade of color

    // Get the brightness value of the color
    int brightness = brightness_of(my_color);

    // Print the brightness value
    write_line("The brightness value of my_color is: " + to_string(brightness));

    // Open a window
    open_window("Brightness Of Example", 400, 400);

    // Draw a filled circle on the screen using the color from above
    clear_screen();
    fill_circle(my_color, 200, 200, 100);
    refresh_screen();

    // Keep the window open for 5 seconds
    delay(5000);

    // Close the window
    close_window("Brightness Of Example");

    return 0;
}
