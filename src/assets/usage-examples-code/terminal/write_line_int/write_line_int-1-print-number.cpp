#include "splashkit.h" 

int main()
{
    // Example 1: Print explicit integer
    write_line(40);

    // Example 2: Print value of integer variable
    int number = 100;
    write_line(number);

    // Example 3: Print combination of explicit integers and integer variable
    write_line(10);
    write_line(number);

    return 0;
}
