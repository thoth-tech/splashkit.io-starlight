#include "splashkit.h"
#include <iostream>
#include <string>
#include <climits>
#include <cstdlib>

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
        int value = std::stoi(input);
        std::cout << "The string contains integer value: " << value << std::endl;
    }
    else
    {
        std::cout << "The input is not a valid integer." << std::endl;
    }

    return 0;
}
