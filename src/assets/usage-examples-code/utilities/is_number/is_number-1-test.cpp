#include <iostream>
#include <string>
#include <sstream>

bool is_number(const std::string& str)
{
    std::istringstream iss(str);
    double number;
    return (iss >> number) ? true : false;
}

int main()
{
    std::string input;
    std::cout << "Enter the value: ";
    std::getline(std::cin, input);

    if (is_number(input))
        std::cout << input << " is a number." << std::endl;
    else
        std::cout << input << " is not a number." << std::endl;

    return 0;
}