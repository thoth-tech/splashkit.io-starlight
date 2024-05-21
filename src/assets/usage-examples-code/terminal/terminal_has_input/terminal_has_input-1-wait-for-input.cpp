#include "splashkit.h" 

int main()
{
    // Example 1: Check if the terminal has input initially
    write_line("Example 1: Checking if terminal has input initially...");
    if (terminal_has_input())
    {
        write_line("Terminal has input.");
    }
    else
    {
        write_line("Terminal does not have input.");
    }

}
