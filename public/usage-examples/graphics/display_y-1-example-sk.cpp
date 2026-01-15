#include "splashkit.h"

int main()
{

    // Set number of displays
    int disp_count = number_of_displays();

    // Declare Variables
    int display_y_values[disp_count];
    display disp_details;

    // Only compare display positions if more than one display is connected
    if (disp_count > 1)
    {
        // Loop through displays
        for (unsigned int i = 0; i < disp_count; i++)
        {
            // Get details for display
            disp_details = display_details(i);

            // Get Y coordinate info for display
            display_y_values[i] = display_y(disp_details);
        }
        // Check that all displays are aligned horizontally 
        for (int i = 0; i < disp_count - 1; i++)
        {
            if (display_y_values[i] != display_y_values[i + 1])
            {
                write_line("Your displays are at different heights");
                break;
            }
        }

    }
    else { write_line("You only have 1 display"); }
    return 0;
}