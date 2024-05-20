#include "splashkit.h"
#include <iostream>
#include <string>

double convert_to_double(const std::string &text)
{
    // Convert the string to a double using the standard library function
    return std::stod(text);
}

bool is_number(const std::string &text)
{
    // Check if the string is a valid number
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
        double value = convert_to_double(input);
        std::cout << "The converted double value is: " << value << std::endl;
    }
    else
    {
        std::cout << "The input is not a valid number." << std::endl;
    }

    return 0;
}
