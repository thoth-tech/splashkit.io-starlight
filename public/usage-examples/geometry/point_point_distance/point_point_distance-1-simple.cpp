#include "splashkit.h"

int main()
{
    // Create and initialise new window with title and dimensions
    window wnd = open_window("Distance From Center", 600, 600);
    clear_screen();

    // Create circle at the center of window 
    fill_circle_on_window(wnd, COLOR_RED, 300, 300, 6);
    refresh_screen();

    // While window is open 
    while(!quit_requested())
    {
        process_events();

        // Point of center 
        point_2d center = screen_center();

        // Point of cursor position 
        point_2d mouse = mouse_position();
        
        // Print distance to terminal 
        write_line(point_point_distance(center, mouse));
    }

    // Close all opened windows
    close_all_windows();
}