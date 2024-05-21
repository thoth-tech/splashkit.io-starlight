#include "splashkit.h"  
#include <string>       

int main()
{
    // Example 1: Prompt and read a single character from the user
    write("Please enter a letter: ");
    char input = read_char();
    write_line("You entered: ");
    write_line(std::string(1, input));

    return 0;
}
