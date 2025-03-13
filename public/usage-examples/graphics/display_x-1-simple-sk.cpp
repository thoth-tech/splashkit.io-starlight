#include "splashkit.h"
using namespace std;
int main()
{

    // Declare Variables
    int disp_x;
    int disp_y;
    display disp_details;
    string DispName;

    // Set number of displays
    int DispCount = number_of_displays();

    write_line("***Display Coordinates***");
    write_line("********************************");
    // Loop through displays
    for (int i = 0; i < DispCount; i++)
    {
        // Set details for display
        disp_details = display_details(i);

        // Get coordinate info for display
        disp_x = display_x(disp_details);
        disp_y = display_y(disp_details);


        // Get name for display
        DispName = display_name(disp_details);

        // Write info to console

        write_line("display Number: " + to_string(i + 1) + " is located at: " + to_string(disp_x) + ", " + to_string(disp_y) + " Coordinates on the display map");
        write_line();
    }
    write_line("********************************");
        return 0;
}