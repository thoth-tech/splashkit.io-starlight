#include "splashkit.h"

int main()
{
    //  Variable Declerations
    point_2d point_1 = point_at(50,75);
    point_2d point_2;
    string guess;
    vector<string> coords;
    double guess_x;
    double guess_y;
    
    
    write_line("Guess the coordinate inside (100,100) ");


    while (true)
    {
        // Get user input
        write("Enter your coordinates as x,y: ");
        guess = read_line();
        coords = split(guess,',');
        guess_x = convert_to_double(coords[0]);
        guess_y = convert_to_double(coords[1]);
        
        // convert input 
        point_2 = point_at(guess_x,guess_y);
        

        //clues
        if (point_1.x > guess_x) 
            write_line("x is to low");
        else if (point_1.x < guess_x) 
            write_line("x is to high");
        else 
            write_line("x is correct !!!");
        
        if (point_1.y > guess_y) write_line("y is to low");
        else if (point_1.y < guess_y) write_line("y is to high");
        else write_line("y is correct !!!");
        
        

        // Point Comparison 
        if(!same_point(point_1,point_2))
        {
            write_line("Try Again!");
        } 
        else 
        {
            write_line("You Win!");
            break;
        }
    }
    


    return 0;
}