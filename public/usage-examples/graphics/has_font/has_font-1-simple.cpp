#include "splashkit.h"
 
int main()
{  
    // Load a font
    load_font("my_font", "arial.ttf");
   
    // Check if the font exit or not
    bool fontCheck = has_font("my_font");
 
    // Display the text to show the result
    if(fontCheck)
    {
        write_line("Font found!");
    }else
    {
        write_line("Font not found!");
    }
}