#include "splashkit.h"  
#include <string>      

int main()
{
    // Generate a random RGB color with alpha 128
    color my_color = random_rgb_color(128);

    // Print the RGBA components of the color
    write_line("The RGBA components of the random color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));
    write_line("Alpha: " + std::to_string(alpha_of(my_color)));

    return 0;
}
