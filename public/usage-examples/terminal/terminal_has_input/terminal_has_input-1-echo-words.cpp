#include "splashkit.h"

int main()
{
    write_line("Welcome to the Terminal Input Checker!");
    write_line("Type something and press Enter to see it echoed back.");
    write_line("Type 'exit' and press Enter to quit the program.");

    string input;

    do
    {
        // Check if there's input waiting in the terminal
        if (terminal_has_input())
        {
            // Read the input
            input = read_line();
            if (input != "exit")
            {
                write_line("You typed: " + input);
            }
        }
        else
        {
            input = ""; // If no input, continue waiting
        }
    } while (input != "exit");

    write_line("Exiting the program...");
    return 0;
}
