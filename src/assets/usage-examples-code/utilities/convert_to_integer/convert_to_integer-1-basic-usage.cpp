#include "splashkit.h"
#include <iostream>
#include <string>
#include <stdexcept>

int convert_to_integer(const std::string &text)
{
    return std::stoi(text);
}

bool is_integer(const std::string &text)
{
    char* end = nullptr;
    long val = strtol(text.c_str(), &end, 10);
    return end != text.c_str() && *end == '\0' && val >= INT_MIN && val <= INT_MAX;
}

int main()
{
    std::string input;
    std::cout << "Enter a number: ";
    std::cin >> input;

    if (is_integer(input))
    {
        try
        {
            int value = convert_to_integer(input);
            std::cout << "The converted integer value is: " << value << std::endl;
        }
        catch (const std::invalid_argument &e)
        {
            std::cout << "Conversion failed: " << e.what() << std::endl;
        }
        catch (const std::out_of_range &e)
        {
            std::cout << "Number out of range: " << e.what() << std::endl;
        }
    }
    else
    {
        std::cout << "The input is not a valid integer." << std::endl;
    }

    return 0;
}
