#include "splashkit.h"

int main()
{
    // Check if "42" is a number
    if (is_number("42"))
        write_line("Is '42' a number? True");
    else
        write_line("Is '42' a number? False");

    // Check if "3.14" is a number
    if (is_number("3.14"))
        write_line("Is '3.14' a number? True");
    else
        write_line("Is '3.14' a number? False");

    // Check if "hello" is a number
    if (is_number("hello"))
        write_line("Is 'hello' a number? True");
    else
        write_line("Is 'hello' a number? False");

    // Check if "12abc" is a number
    if (is_number("12abc"))
        write_line("Is '12abc' a number? True");
    else
        write_line("Is '12abc' a number? False");

    return 0;
}
