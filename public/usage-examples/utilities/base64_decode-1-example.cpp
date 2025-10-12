#include "splashkit.h"

int main()
{
    string encoded = "SGVsbG8gU3BsYXNoS2l0";

    // Decode a Base64 string back to plain text
    string decoded = base64_decode(encoded);

    // Print the Base64 input and the decoded output
    write_line("Base64: " + encoded);
    write_line("Decoded: " + decoded);

    return 0;
}
