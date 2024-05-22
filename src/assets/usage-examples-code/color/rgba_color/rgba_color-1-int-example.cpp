#include "splashkit.h"  
#include <string>       

int main()
{
    // Create a color using integer values for red, green, blue, and alpha components
    color my_color = rgba_color(123, 234, 56, 128);

    // Print the RGBA components of the color
    write_line("The RGBA components of the color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));
    write_line("Alpha: " + std::to_string(alpha_of(my_color)));

    return 0;
}
