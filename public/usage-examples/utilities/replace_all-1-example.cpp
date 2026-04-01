#include "splashkit.h"

int main()
{
    string sentence = "foo fighters say foo is fun";
    string updated_sentence = replace_all(sentence, "foo", "bar");

    write_line("Original: " + sentence);
    write_line("Updated: " + updated_sentence);

    return 0;
}
