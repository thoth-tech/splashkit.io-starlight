#include "splashkit.h"

int main()
{
    open_window("Circular Toggle Button", 800, 600);

    while (!quit_requested())
    {
        process_events();

        //Declaring the variables
        color circle_color;
        point_2d cursor_pos = mouse_position();
        circle circle = circle_at(400, 300, 80);

        clear_screen();

        if (point_in_circle(cursor_pos, circle))
        {
            circle_color = color_green();
            draw_text("Point is in the circle", color_green(), 300, 100);
        }
        else
        {
            circle_color = color_bright_green();
            draw_text("Point is not in the circle", color_red(), 300, 100);
        }
        
        fill_circle(circle_color, circle);
        draw_text("Button", color_black(), 375, 300);
        
        refresh_screen();
    }

    close_all_windows();
    return 0;
}