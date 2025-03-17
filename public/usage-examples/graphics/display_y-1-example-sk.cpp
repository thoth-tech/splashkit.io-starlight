#include "splashkit.h"

int main()
{

    // Set number of displays
    int disp_count = number_of_displays();

    // Declare Variables
    int disp_y[disp_count];
    display disp_details;

    // Check for more that 1 display
    if (disp_count > 1)
    {
        // Loop through displays
        for (unsigned int i = 0; i < disp_count; i++)
        {
            // Get details for display
            disp_details = display_details(i);

            // Get Y coordinate info for display
            disp_y[i] = display_y(disp_details);
        }
        // Check that all displays are on the same Y to determine verticality  
        for (int i = 0; i < disp_count - 1; i++)
        {
            if (disp_y[i] != disp_y[i + 1])
            {
                write_line("Your displays are at different heights");
                break;
            }
        }

    }
    else { write_line("You only have 1 display"); }
    return 0;
}