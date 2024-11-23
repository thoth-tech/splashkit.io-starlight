#include "splashkit.h"


int main()
{

    //Variable Declartions

    line ln = line_from(100,300,500,300);
    // Create window
    open_window("point on line",600,600);
    

    while (! quit_requested())
    {
        
        //Display line
        clear_screen(color_white());
        draw_line(color_black(),ln);

        //Draw text if curser is on line
        if( point_on_line(mouse_position(),ln) )
        {

            draw_text("Point on line" + point_to_string(mouse_position()),color_black(),200,450);
            
        }
        refresh_screen();
        process_events();
    }
    
    return 0;
}