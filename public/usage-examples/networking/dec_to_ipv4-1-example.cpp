#include "splashkit.h"

int main()
{
    write_line("Hello! Welcome to the decimal to IPv4 converter.");

    // Prompt the user for a decimal input
    write_line("Please enter a decimal number (e.g., 2130706433):");

    // Read the input as a string
    string dec_input = read_line();

    // Convert the input string to an unsigned integer
    unsigned int dec_value = convert_to_integer(dec_input);

    // Convert the decimal value to a dotted decimal IPv4 address
    string ip_address = dec_to_ipv4(dec_value);

    // Display the result in dotted decimal format
    write_line("The decimal value as an IPv4 address is: " + ip_address);

    return 0;
}
