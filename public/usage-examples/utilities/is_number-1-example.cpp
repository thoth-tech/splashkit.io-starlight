#include "splashkit.h"

int main()
{
    // Check if "42" is a number
    bool result1 = is_number("42");
    write_line("Is '42' a number? " + to_string(result1));

    // Check if "3.14" is a number
    bool result2 = is_number("3.14");
    write_line("Is '3.14' a number? " + to_string(result2));

    // Check if "hello" is a number
    bool result3 = is_number("hello");
    write_line("Is 'hello' a number? " + to_string(result3));

    // Check if "12abc" is a number
    bool result4 = is_number("12abc");
    write_line("Is '12abc' a number? " + to_string(result4));

    return 0;
}
