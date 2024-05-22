#include "splashkit.h"
#include <iostream>
#include <string>
#include <cstdlib>

bool is_number(const std::string &text)
{
    char* end = nullptr;
    strtod(text.c_str(), &end);
    return end != text.c_str() && *end == '\0';
}

int main()
{
    std::string input;
    std::cout << "Enter a number: ";
    std::cin >> input;

    if (is_number(input))
    {
        double value = std::stod(input);
        std::cout << "The string contains number value: " << value << std::endl;
    }
    else
    {
        std::cout << "The input is not a valid number." << std::endl;
    }

    return 0;
}
