#include "splashkit.h"
#include <iostream>

using namespace std;

// Replace all occurrences of "foo" with "bar" in a sentence.
int main()
{
    string text = "foo is fun, and foo is useful.";
    string updated = replace_all(text, "foo", "bar");

    cout << "Original: " << text << endl;
    cout << "Updated: " << updated << endl;

    return 0;
}