#include "splashkit.h"  

int main()
{
    // Create a color
    color my_color = rgb_color(123, 234, 56);

    // Get the hue component of the color
    double hue = hue_of(my_color);

    // Print the hue component
    write_line("The hue component of the color is: " + std::to_string(hue));

    return 0;
}
