#include "splashkit.h"  

int main()
{
    // Create a color using HSB values
    color my_color = hsb_color(180.0, 0.5, 0.75);

    // Print the RGB components of the color
    write_line("The RGB components of the color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));

    return 0;
}
