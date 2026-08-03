#include "splashkit.h"

int main()
{
    // Find the GCD of 12 and 8
    int result1 = greatest_common_divisor(12, 8);
    write_line("GCD of 12 and 8 is: " + to_string(result1));

    // Find the GCD of 100 and 75
    int result2 = greatest_common_divisor(100, 75);
    write_line("GCD of 100 and 75 is: " + to_string(result2));

    // Find the GCD of 7 and 13 (both prime, so GCD is 1)
    int result3 = greatest_common_divisor(7, 13);
    write_line("GCD of 7 and 13 is: " + to_string(result3));

    // Find the GCD of 36 and 60
    int result4 = greatest_common_divisor(36, 60);
    write_line("GCD of 36 and 60 is: " + to_string(result4));

    return 0;
}
