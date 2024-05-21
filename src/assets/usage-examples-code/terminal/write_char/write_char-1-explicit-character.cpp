#include "splashkit.h"  

int main()
{
    // Example 1: Print explicit character
    write('A');
    write_line();

    // Example 2: Print value of character variable
    char letter = 'B';
    write(letter);
    write_line();

    // Example 3: Print combination of explicit characters and character variable
    write('C');
    write(' ');
    write(letter);

    return 0;
}
