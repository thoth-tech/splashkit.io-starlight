#include "splashkit.h"

int main()
{   
    // Read the data for Circle A
    write_line("X coordinate for circle A: ");
    int X_A = convert_to_integer(read_line());
    write_line("Y coordinate for circle A: ");
    int Y_A = convert_to_integer(read_line());
    write_line("Radient for circle A: ");
    int R_A = convert_to_integer(read_line());
    
    // Create circle A based on the user's data
    circle A = circle_at(X_A, Y_A, R_A);

    // Read the data for Circle B
    write_line("X coordinate for circle B: ");
    int X_B = convert_to_integer(read_line());
    write_line("Y coordinate for circle B: ");
    int Y_B = convert_to_integer(read_line());
    write_line("Radient for circle B: ");
    int R_B = convert_to_integer(read_line());

    // Create circle B based on the user's data
    circle B = circle_at(X_B, Y_B , R_B);
    
    // Detect if the circles intersect
    if(circles_intersect(A, B))
    {
        write_line("The circles intersect!");
    }
    else{
        write_line("The circles do not intersect!");
    }

    // Create a window 
    open_window("Circle Intersect", 800, 600);
    clear_screen();

    // Draw the circles based on the data given by user
    draw_circle(COLOR_RED, X_A, Y_A, R_A);
    draw_circle(COLOR_RED, X_B, Y_B, R_B);

    refresh_screen();
    delay(4000);
    close_all_windows();
}