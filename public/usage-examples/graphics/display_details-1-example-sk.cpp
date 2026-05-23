#include "splashkit.h"

int main()
{   
    // Declare Variables
    display disp_details;
    
    write_line("***Display Info***");

    // Loop through displays
    for (unsigned int i = 0; i < number_of_displays(); i++)
    {
        // Set details for display
        disp_details = display_details(i);

        // Write info to console
        write_line("********************************");
        write_line("  Display Number: " + std::to_string(i + 1));
        write_line("   Name: " + display_name(disp_details));
        write_line("   Coordinates (X,Y): " + std::to_string(display_x(disp_details)) + ", " + std::to_string(display_y(disp_details)));
        write_line("   Resolution: " + std::to_string(display_width(disp_details)) + "x" + std::to_string(display_height(disp_details)));
    }
    write_line("********************************"); 
    return 0;
};