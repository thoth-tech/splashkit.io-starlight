#include "splashkit.h"

int main()
{
    string binary_value = "111110011010";
    string hex_value = bin_to_hex(binary_value); // SplashKit function

    write_line("Binary: " + binary_value);
    write_line("Hex: " + hex_value);

    return 0;
}
