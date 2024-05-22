#include "splashkit.h"  
#include <string>     

int main()
{
    // Create a color
    color my_color = rgb_color(123, 234, 56);

    // Get the red component of the color
    int red = red_of(my_color);

    // Print the red component
    write_line("The red component of the color is: " + std::to_string(red));

    return 0;
}
