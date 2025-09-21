#include "splashkit.h"

int main()
{
    open_window("Interaction of Line and Circle", 800, 600);

    while (!quit_requested())
    {
        process_events();

        //Defining line and circle
        point_2d cursor_pos = mouse_position();
        line line = line_from(point_at(150, 100), cursor_pos);
        circle circle = circle_at(400, 300, 100);

        clear_screen();

        //Drawing line and circle
        draw_line(COLOR_BLUE, line);
        draw_circle(COLOR_BLACK, circle);

        //Check for intersection and display results
        if (line_intersects_circle(line, circle))
        {
            draw_text("Line and Circle intersect", COLOR_GREEN, 400, 100);
        }
        else
        {
            draw_text("Line and Circle do not intersect", COLOR_RED, 400, 100);
        }

        refresh_screen(); 
    }
    
    close_all_windows();
    return 0;
}