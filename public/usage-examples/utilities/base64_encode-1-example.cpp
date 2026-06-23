#include "splashkit.h"

int main()
{
    string text = "Hello SplashKit";

    // Encode a plain string into Base64
    string encoded = base64_encode(text);

    // Display the original and encoded values
    write_line("Original: " + text);
    write_line("Base64: " + encoded);

    return 0;
}
