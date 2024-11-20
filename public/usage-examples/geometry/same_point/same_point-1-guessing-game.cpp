#include "splashkit.h"

int main()
{
    //  Variable Declerations
    point_2d point_1 = point_at(50,75);
    point_2d point_2;
    string guess;
    vector<string> coords;
    
    
    write_line("Guess the coordinate inside (100,100) ");


    while (true)
    {
        // Get user input
        write("Enter your coordinates as x,y: ");
        guess = read_line();
        coords = split(guess,',');
        
        // convert input 
        point_2 = point_at(convert_to_double(coords[0]),convert_to_double(coords[1]));
        
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