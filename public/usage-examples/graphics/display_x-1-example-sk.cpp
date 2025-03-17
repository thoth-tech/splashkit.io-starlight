#include "splashkit.h"

int main()
{

    // Declare Variables
    display disp_details;

    write_line("***Display Coordinates***");
    write_line("********************************");
    // Loop through displays
    for (unsigned int i = 0; i < number_of_displays(); i++)
    {
        // Set details for display
        disp_details = display_details(i);

        // Write info to console
        write_line("display Number: " + std::to_string(i + 1) + " is located at: " + std::to_string(display_x(disp_details)) + ", "  + std::to_string(display_y(disp_details)) + " Coordinates on the display map");
        write_line();
    }
    write_line("********************************");
    return 0;
}