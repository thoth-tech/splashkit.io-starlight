#include "splashkit.h"

int main()
{
    // Split a CSV string by comma
    vector<string> parts = split("apple,banana,cherry,date", ',');
    write_line("Split 'apple,banana,cherry,date' by ',':");
    for (int i = 0; i < parts.size(); i++)
    {
        write_line("  [" + to_string(i) + "] " + parts[i]);
    }

    // Split a sentence by space
    vector<string> words = split("Hello World SplashKit", ' ');
    write_line("Split 'Hello World SplashKit' by ' ':");
    for (int i = 0; i < words.size(); i++)
    {
        write_line("  [" + to_string(i) + "] " + words[i]);
    }

    // Split a path by slash
    vector<string> folders = split("home/user/documents", '/');
    write_line("Split 'home/user/documents' by '/':");
    for (int i = 0; i < folders.size(); i++)
    {
        write_line("  [" + to_string(i) + "] " + folders[i]);
    }

    return 0;
}
