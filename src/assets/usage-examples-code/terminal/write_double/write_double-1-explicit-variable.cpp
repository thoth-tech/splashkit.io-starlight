#include "splashkit.h"  

int main()
{
    // Example 1: Print explicit double
    write(3.14159);
    write_line();

    // Example 2: Print value of double variable
    double pi = 3.14159;
    write(pi);
    write_line();

    // Example 3: Print combination of explicit doubles and double variable
    write(1.61803);
    write(' ');
    write(pi);

    return 0;
}
