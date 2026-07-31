#include "splashkit.h"

int main()
{
    string text = "I like cats. cats are great. I have two cats.";
    write_line("Original: " + text);

    // Replace all occurrences of "cats" with "dogs"
    string result = replace_all(text, "cats", "dogs");
    write_line("Replaced: " + result);

    string greeting = "Hello World! Hello Everyone!";
    write_line("\nOriginal: " + greeting);

    // Replace all occurrences of "Hello" with "Hi"
    string new_greeting = replace_all(greeting, "Hello", "Hi");
    write_line("Replaced: " + new_greeting);

    return 0;
}
