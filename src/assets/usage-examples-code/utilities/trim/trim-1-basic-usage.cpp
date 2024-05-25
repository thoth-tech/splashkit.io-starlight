#include "splashkit.h"

int main()
{
    string text = "   Hello, World!   ";
    string trimmed_text = trim(text);

    write_line("Original: '" + text + "'");
    write_line("Trimmed: '" + trimmed_text + "'");

    return 0;
}
