#include <iostream>
#include "splashkit.h"

int main()
{
    std::string inputText;
    std::cout << "Enter a text: ";
    std::getline(std::cin, inputText); // Read user input
    std::string lowerCaseText = to_lowercase(inputText);
    std::cout << "Original text: " << inputText << std::endl;
    std::cout << "Lowercase text: " << lowerCaseText << std::endl;
    return 0;
}
