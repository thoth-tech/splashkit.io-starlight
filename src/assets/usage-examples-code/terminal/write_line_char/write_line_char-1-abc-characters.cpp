#include "splashkit.h"  
#include <string>       

int main()
{
    // Example 1: Print explicit character
    write_line(std::string(1, 'A'));

    // Example 2: Print value of character variable
    char letter = 'B';
    write_line(std::string(1, letter));

    // Example 3: Print combination of explicit characters and character variable
    write_line(std::string(1, 'C'));
    write_line(std::string(1, ' '));
    write_line(std::string(1, letter));

    return 0;
}
