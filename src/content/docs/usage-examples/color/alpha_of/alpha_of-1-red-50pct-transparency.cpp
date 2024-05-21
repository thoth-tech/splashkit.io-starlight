#include "splashkit.h"

using std::to_string;

int main()
{
    // Define a color with an alpha value (Red with 50% transparency)
    color my_color = rgba_color(255, 100, 50, 255);

    // Get the alpha value of the color
    int alpha = alpha_of(my_color);

    // Print the alpha value
    write_line("The alpha value of my_color is: " + to_string(alpha));

    // Open a window
    open_window("Alpha Of Example", 400, 400);

    // Draw a filled circle on the screen using the color from above
    clear_screen();
    fill_circle(my_color, 200, 200, 100);
    refresh_screen();

    // Keep the window open for 5 seconds
    delay(5000);

    // Close the window
    close_window("Alpha Of Example");
    

    return 0;
}
