#include "splashkit.h"



int main()
{
    // declare variables
    int const trail_length = 50;
    point_2d mouse_point;
    point_2d mouse_history[trail_length] = {};
    color color_list[5] = {color_blue(),color_red(),color_green(),color_yellow(),color_pink()};


    open_window("draw pixel", 600, 600);


    while(!quit_requested())
    {
    
        mouse_point = mouse_position();
        clear_screen(color_black());
        // set mouse position history 
        for(int i = 0; i < trail_length - 1; i++)
        {
            // shuffle forward
            mouse_history[i] = mouse_history[i + 1];
        }
        mouse_history[trail_length - 1] = mouse_point;
        // draw mouse trail
        for(int i = 0; i < trail_length; i++)
        {
            draw_pixel(color_list[i%5],mouse_history[i]);
        }
        process_events();
        refresh_screen(60);
    }
    close_all_windows();
    return 0;
}