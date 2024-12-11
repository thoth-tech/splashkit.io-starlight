#include "splashkit.h"

int main()
{
    // Load font and size 
    load_font("BebasNeue", "BebasNeue.ttf");
    font_load_size("BebasNeue", 20);

    // Prompt user 
    write("What size would you like to check?: ");
    string input = read_line();

    // Convert input to integer 
    int size = convert_to_integer(input);
    bool isSize = font_has_size("BebasNeue", size);

    // If user input is size of font 
    if (isSize)
    {
        write_line("APPROVED");
        write_line("Current font size is " + input);
    }
    else // If user input is not size of font
    {
        write_line("ERROR");
        write_line("Font size is NOT " + input);
    }
}