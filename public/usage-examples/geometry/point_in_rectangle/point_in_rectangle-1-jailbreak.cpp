#include "splashkit.h"

int main()
{

    //Variable declarations
    point_2d mouse_point;
    rectangle boundary = rectangle_from(150,150,300,100);
    

    open_window("point in rectangle", 600, 600);


    while(!quit_requested())
    {
        
        // get mouse position and draw boundary to screen
        mouse_point = mouse_position();
        clear_screen(color_green());
        fill_rectangle(color_white(), boundary);

        // Check if moust is in the boundary
        while(!point_in_rectangle(mouse_point,boundary))
        {

            //flash screen red and blue if mouse has escaped boundary
            clear_screen(color_dark_red());
            fill_rectangle(color_white(), boundary);
            draw_text("JAILBREAK",COLOR_BLACK,250.0,400.0);
            refresh_screen(2);
            clear_screen(color_royal_blue());
            fill_rectangle(color_white(), boundary);
            refresh_screen(2);
            mouse_point = mouse_position();
            
            process_events();
            if(quit_requested()){break;}
        }
        
        process_events();
        refresh_screen();
    }
    


    return 0;
}