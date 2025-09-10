#include "splashkit.h"

int main()
{
    // Open a new window
    window wnd = open_window("Line Game", 800, 600);

    // Define start and end points of line 
    point_2d pnt1 = point_at(0, 400);
    point_2d pnt2 = point_at(800, 400);

    // Create a line 
    line lne = line_from(pnt1, pnt2);
    clear_screen();

    // Draw the line to make it visible
    draw_line_on_window(wnd, COLOR_BLACK, lne);

    // Draw circles to indicate start and finish 
    fill_circle_on_window(wnd, COLOR_GREEN, 15, 400, 3);
    fill_circle_on_window(wnd, COLOR_RED, 785, 400, 3);

    // Load font and draw instructions text 
    font font1 = load_font("NunitoSans", "NunitoSans.ttf");
    draw_text_on_window(wnd, "Put your cursor on the line and move from the green to red dot without straying from the line", COLOR_BLACK, font1, 14, 100, 200);
    refresh_screen();
    delay(3000); // Wait 3 seconds

    // While window is open 
    while(!quit_requested())
    {
        process_events();

        // Define user's mouse position 
        point_2d user = mouse_position();

        // Get distance between cursor and line 
        float distance = point_line_distance(user, lne);

        // Print to terminal
        write_line(distance);
        delay(300);

        // If distance is 3 or more 
        if (distance >= 3)
        {   
            write_line("Game Over");
            // Break loop 
            break;
        }
    }

    // Close all opened windows 
    free_font(font1);
    close_all_windows();  
}