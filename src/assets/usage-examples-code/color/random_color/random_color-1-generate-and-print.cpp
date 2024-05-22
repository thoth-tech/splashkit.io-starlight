#include "splashkit.h"  

int main()
{
    // Generate a random color
    color my_color = random_color();

    // Print the RGB components of the color
    write_line("The RGB components of the random color are: ");
    write_line("Red: " + std::to_string(red_of(my_color)));
    write_line("Green: " + std::to_string(green_of(my_color)));
    write_line("Blue: " + std::to_string(blue_of(my_color)));

    return 0;
}
