#include "splashkit.h" 

int main()
{
    // Example 1: Print explicit string
    write("Hello, World!");
    write_line();

    // Example 2: Print value of string variable
    string greeting = "Hello from a variable";
    write(greeting);
    write_line();

    // Example 3: Print combination of explicit strings and string variable
    write("Welcome to ");
    write(greeting);

    return 0;
}
