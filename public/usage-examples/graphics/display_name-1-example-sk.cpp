#include "splashkit.h"

int main()
{
    // Get number of displays
    int num_displays = number_of_displays();
    string disp_name = display_name(display_details(0));
    
    // Print main display name and number of displays
    write_line("The name of your main display is: " + disp_name);
    write_line("You have " + std::to_string(num_displays) + " displays connected.");

    // Print names of secondary displays
    write_line("Your secondary displays are called: ");
    for (unsigned int i = 1; i < num_displays; i++)
    {
        disp_name =  display_name(display_details(i));
        write_line(disp_name);
    }
    return 0;
}