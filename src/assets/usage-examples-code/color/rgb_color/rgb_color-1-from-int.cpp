#include "splashkit.h"  
#include <string>      

int main()
{
    // Create a color using integer values for red, green, and blue components
    color my_color = rgb_color(123, 234, 56);

    // Print the RGB components of the color
    write_line("The RGB components of the color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));

    return 0;
}
