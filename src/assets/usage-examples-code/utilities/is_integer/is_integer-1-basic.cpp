// I am reading text until the user types q, and I am printing whether each line is an integer.

#include "splashkit.h"

int main()
{
    write_line("Is Integer Checker");
    write_line("Type a value and press Enter. Type q to quit.");

    bool running = true;
    while (running)
    {
        write("> ");
        string text = read_line();

        if (text == "q" || text == "quit")
        {
            running = false;
        }
        else
        {
            // I am using SplashKit is_integer so users learn the utility call
            if (is_integer(text))
            {
                write_line("Integer");
            }
            else
            {
                write_line("Not integer");
            }
        }
    }

    write_line("Bye");
    return 0;
}