#include "splashkit.h"  

int main()
{
    // Example: Prompt and read a line of input from the user
    write("Please enter a line of text: ");
    string input = read_line();
    write("You entered: ");
    write(input);

    return 0;
}
