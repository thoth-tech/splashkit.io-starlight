#include "splashkit.h"

int main()
{
    write_line("Hello! Welcome to the MAC address checker.");

    // Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
    write_line("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):");

    // Read the input as a string
    string mac_input = read_line();

    // Check the address before trying to convert or store it
    bool address_is_valid = is_valid_mac(mac_input);

    // Tell the user whether the address can be used
    if (address_is_valid)
    {
        write_line(mac_input + " is a valid MAC address.");
    }
    else
    {
        write_line(mac_input + " is not a valid MAC address.");
    }

    return 0;
}
