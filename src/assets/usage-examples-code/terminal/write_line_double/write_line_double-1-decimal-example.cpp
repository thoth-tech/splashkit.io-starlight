#include "splashkit.h"  

int main()
{
    // Example 1: Print explicit double
    write_line(1.14);

    // Example 2: Print value of double variable
    double pi = 1.14;
    write_line(pi);

    // Example 3: Print combination of explicit doubles and double variable
    write_line(1.61);
    write_line(pi);

    return 0;
}
