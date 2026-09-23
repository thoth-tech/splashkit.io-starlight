#include "splashkit.h"

int main()
{
    // Find the square root of 25
    double result1 = square_root(25);
    write_line("Square root of 25 is: " + to_string(result1));

    // Find the square root of 144
    double result2 = square_root(144);
    write_line("Square root of 144 is: " + to_string(result2));

    // Find the square root of 2 (irrational)
    double result3 = square_root(2);
    write_line("Square root of 2 is: " + to_string(result3));

    // Find the square root of 0
    double result4 = square_root(0);
    write_line("Square root of 0 is: " + to_string(result4));

    return 0;
}
