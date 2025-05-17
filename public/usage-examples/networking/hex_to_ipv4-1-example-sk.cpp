#include "splashkit.h"

int main()
{
    write_line("Welcome to the hexadecimal to ipv4 converter.");

    // Prompt the user for a hexadecimal input
    write_line("Please enter a hexadecimal number:");

    // Read the input as a string
    string hex_input = read_line();

    // Convert the hexadecimal string to a ipv4 
    string ipv4_value = hex_str_to_ipv4(hex_input);

    // Display the result in decimal format
    write_line("The hexadecimal value in ipv4 format is: " + ipv4_value);

    return 0;
}