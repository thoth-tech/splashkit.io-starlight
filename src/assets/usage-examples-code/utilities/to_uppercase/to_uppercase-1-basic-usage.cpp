#include <iostream>
#include "splashkit.h"

int main()
{
    std::string inputText;
    std::cout << "Enter a text: ";
    std::getline(std::cin, inputText); // Read user input
    std::string upperCaseText = to_uppercase(inputText);
    std::cout << "Original text: " << inputText << std::endl;
    std::cout << "Uppercase text: " << upperCaseText << std::endl;
    return 0;
}
