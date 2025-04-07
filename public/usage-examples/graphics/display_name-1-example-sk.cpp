#include "splashkit.h"

int main()
{
    // Get number of displays
    int num_displays = number_of_displays();

    // Print main display name and number of displays
    write_line("The name of your main display is: " + display_name(display_details(0)));
    write_line("You have " + std::to_string(num_displays) + " displays connected.");

    // Print names of secondary displays
    write_line("Your secondary displays are called: ");
    for (unsigned int i = 1; i < num_displays; i++)
    {
        write_line(display_name(display_details(i)));
    }
    return 0;
}