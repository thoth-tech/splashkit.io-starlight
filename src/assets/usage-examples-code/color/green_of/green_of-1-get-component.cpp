#include "splashkit.h"  
#include <string>      

int main()
{
    // Create a color
    color my_color = rgb_color(123, 234, 56);

    // Get the green component of the color
    int green = green_of(my_color);

    // Print the green component
    write_line("The green component of the color is: " + std::to_string(green));

    return 0;
}
