#include "splashkit.h"
#include <iostream>

int main()
{
    unsigned int first_ip = 2130706433;
    unsigned int second_ip = 3232235777;
    unsigned int third_ip = 134744072;

    // Convert decimal IP values into IPv4 addresses
    string first_address = dec_to_ipv4(first_ip);
    string second_address = dec_to_ipv4(second_ip);
    string third_address = dec_to_ipv4(third_ip);

    std::cout << "Decimal to IPv4 Conversion" << std::endl;
    std::cout << std::endl;

    std::cout << first_ip << " -> " << first_address << std::endl;
    std::cout << second_ip << " -> " << second_address << std::endl;
    std::cout << third_ip << " -> " << third_address << std::endl;

    return 0;
}