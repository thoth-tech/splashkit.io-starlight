#include "splashkit.h"  

int main()
{
    // Example 1: Print explicit integer
    write(42);
    write_line();

    // Example 2: Print value of integer variable
    int number = 100;
    write(number);
    write_line();

    // Example 3: Print combination of explicit integer and value of integer variable
    int base = 10;
    write(base * 5);
    write_line();

    return 0;
}
