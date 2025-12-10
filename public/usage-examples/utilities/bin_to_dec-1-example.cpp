#include "splashkit.h"

int main()
{
    string binary_value = "1111010";
    int decimal_value = bin_to_dec(binary_value); // SplashKit function

    write_line("Binary: " + binary_value);
    write_line("Decimal: " + std::to_string(decimal_value));

    return 0;
}
