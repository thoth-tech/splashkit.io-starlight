#include "splashkit.h"  
#include <string>       

int main()
{
    // Create a color
    color my_color = rgb_color(123, 234, 56);

    // Get the saturation component of the color
    double saturation = saturation_of(my_color);

    // Print the saturation component
    write_line("The saturation component of the color is: " + std::to_string(saturation));

    return 0;
}
