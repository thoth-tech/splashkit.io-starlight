#include "splashkit.h"
#include <string>

// Function to convert double to string
string convert_to_string(double x)
{
    return std::to_string(x);
}

int main()
{

    //Variable Declartions
    double bar_x = 100;
    line slider = line_from(100,300,500,300);
    line bar = line_from(bar_x,310,bar_x,290);
    double percent = 0;
    string volume = "Volume: ";


    // Create window and draw initial lines
    open_window("point on line",600,600);
    clear_screen(color_white());

    draw_line(color_black(),slider);
    draw_line(color_black(),bar);
    draw_text(volume + convert_to_string(percent),color_black(),200,450);
    refresh_screen();

    while (! quit_requested())
    {
        
        process_events();

        // Check if user is holding click on the bar line
        while (mouse_down(LEFT_BUTTON) & point_on_line(mouse_position(),bar))
        {

            clear_screen(color_white());
            bar_x = mouse_position().x; // sets bar_x value to mouse x value
            percent = ((bar_x - 100) / (500 - 100)) * 100; // convert bar_x position to percent value
            bar = line_from(bar_x,310,bar_x,290);
            
            // redraw lines and volume text
            draw_line(color_black(),bar);
            draw_line(color_black(),slider);
            draw_text(volume + convert_to_string(percent),color_black(),200,450);
            refresh_screen();
            process_events();

        }

        
    }
    
    return 0;
}