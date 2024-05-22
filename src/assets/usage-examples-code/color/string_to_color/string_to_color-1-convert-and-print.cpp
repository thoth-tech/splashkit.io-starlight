#include "splashkit.h"  // Include SplashKit library for color functions
#include <string>       // Include for std::to_string

int main()
{
    // Convert a string representation of a color to a color object
    color my_color = string_to_color("#FF5733");  // Some color in hexadecimal format

    // Print the RGB components of the color
    write_line("The RGB components of the color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));

    return 0;
}
