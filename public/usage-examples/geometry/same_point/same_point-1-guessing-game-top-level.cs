#include "splashkit.h"

int main()
{
    //  Variable declarations
    point_2d point_1 = point_at(50, 75);
    point_2d point_2;
    string guess_input;
    vector<string> coords;
    double guess_x;
    double guess_y;
    bool guess = false;

    write_line("Guess the coordinate inside (100,100)");

    while (!guess)
    {
        // Get user input
        write("Enter your coordinates as x,y: ");
        guess_input = read_line();
        coords = split(guess_input, ',');

        // Convert input 
        guess_x = convert_to_double(coords[0]);
        guess_y = convert_to_double(coords[1]);
        point_2 = point_at(guess_x, guess_y);

        // Clues
        if (point_1.x > guess_x)
            write_line("x is too low");
        else if (point_1.x < guess_x)
            write_line("x is too high");
        else
            write_line("x is correct !!!");

        if (point_1.y > guess_y)
            write_line("y is too low");
        else if (point_1.y < guess_y)
            write_line("y is too high");
        else
            write_line("y is correct !!!");

        // Point comparison 
        guess = same_point(point_1, point_2);
        if (!guess)
        {
            write_line("Try Again!");
        }
        else
        {
            write_line("You Win!");
        }
    }

    return 0;
}
