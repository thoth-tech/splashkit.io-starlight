#include "splashkit.h"

int main()
{
    string input = "Hello World";
    string encoded = base64_encode(input);
    
    write_line("Original: " + input);
    write_line("Encoded: " + encoded);
    
    return 0;
}