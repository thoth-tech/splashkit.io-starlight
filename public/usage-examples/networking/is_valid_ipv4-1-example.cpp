#include "splashkit.h"

int main()
{
    write_line("Hello! Welcome to the IPv4 address checker.");

    // Prompt the user for an IP input in dotted decimal format
    write_line("Please enter an IPv4 address in dotted decimal format (e.g., 192.168.0.1):");

    // Read the input as a string
    string ip_input = read_line();

    // Check the address before trying to use it elsewhere
    bool address_is_valid = is_valid_ipv4(ip_input);

    // Tell the user whether the address can be used
    if (address_is_valid)
    {
        write_line(ip_input + " is a valid IPv4 address.");
    }
    else
    {
        write_line(ip_input + " is not a valid IPv4 address.");
    }

    return 0;
}
