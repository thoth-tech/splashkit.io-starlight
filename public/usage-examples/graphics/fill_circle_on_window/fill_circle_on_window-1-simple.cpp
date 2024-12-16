#include "splashkit.h"

int main()
{
    // Open a new window and initialize to a window variable wnd1
    window wnd1 = open_window("Traffic Lights", 800, 600);
    clear_screen();

    // Use function to place 3 circles in destination window (wnd1) as traffic lights
    fill_circle_on_window(wnd1, COLOR_RED, 400, 100, 50);
    fill_circle_on_window(wnd1, COLOR_YELLOW, 400, 250, 50);
    fill_circle_on_window(wnd1, COLOR_GREEN, 400, 400, 50);

    refresh_screen();
    delay(5000);

    //Close loaded windows   
    close_all_windows();
}



