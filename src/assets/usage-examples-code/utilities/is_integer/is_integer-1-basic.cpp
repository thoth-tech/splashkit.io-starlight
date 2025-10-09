// Usage Example for: https://splashkit.io/api/text/#is-integer
// Goal: I am reading text and I am printing whether each line is an integer.
// Why: I am showing how to use is_integer in a simple REPL.
// Controls: I am typing q or quit to exit.

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
            // I am using is_integer so I am learning the utility call
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