#include "splashkit.h"

int main()
{
    write_line("Check the ASCII value of a character.");
    write_line("Press 'q' to quit, or type any character to see its ASCII value.");

    while (true)
    {
        write("Enter a character: ");
        char input = read_char(); // Read a single character input

        if (input == 'q') // Quit if 'q' is pressed
        {
            write_line("You pressed 'q'. Exiting the program. Goodbye!");
            break;
        }
        else
        {
            // Display the ASCII value of the character
            write_line("You pressed '" + string(1, input) + "' (ASCII: " + std::to_string(int(input)) + ").");
        }
    }
}
