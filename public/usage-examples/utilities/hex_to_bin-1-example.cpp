#include "splashkit.h"

int main()
{
    string hex_value = "1F3A";
    string binary_value = hex_to_bin(hex_value); // SplashKit function

    write_line("Hex: " + hex_value);
    write_line("Binary: " + binary_value);

    return 0;
}

