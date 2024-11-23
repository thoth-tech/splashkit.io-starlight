#include "splashkit.h"
#include <vector>

int main()
{
    // Prompt user for input string and delimiter
    string text;
    char delimiter;

    write("Enter a string to split: ");
    text = read_line();

    write("Enter a delimiter character: ");
    string delimiter_input = read_line();

    // Ensure the delimiter is a single character
    if (delimiter_input.length() != 1)
    {
        write_line("Please enter a single character as the delimiter.");
    }
    else
    {
        delimiter = delimiter_input[0];

        // Split the input string
        vector<string> result = split(text, delimiter);

        // Display the split substrings
        write_line("Split result:");
        for (string part : result)
        {
            write_line("- " + part);
        }
    }
}
