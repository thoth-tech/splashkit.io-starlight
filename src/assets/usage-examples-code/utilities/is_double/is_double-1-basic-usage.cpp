#include "splashkit.h"
#include <iostream>
#include <string>

bool is_double(const std::string &text)
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

    if (is_double(input))
    {
        double value = std::stod(input);
        std::cout << "The string contains double value:: " << value << std::endl;
    }
    else
    {
        std::cout << "The input is not a valid double." << std::endl;
    }

    return 0;
}
