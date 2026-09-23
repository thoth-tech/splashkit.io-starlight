using static SplashKitSDK.SplashKit;
using System.Collections.Generic;

// Split a CSV string by comma
List<string> parts = Split("apple,banana,cherry,date", ',');
WriteLine("Split 'apple,banana,cherry,date' by ',':");
for (int i = 0; i < parts.Count; i++)
{
    WriteLine("  [" + i + "] " + parts[i]);
}

// Split a sentence by space
List<string> words = Split("Hello World SplashKit", ' ');
WriteLine("Split 'Hello World SplashKit' by ' ':");
for (int i = 0; i < words.Count; i++)
{
    WriteLine("  [" + i + "] " + words[i]);
}

// Split a path by slash
List<string> folders = Split("home/user/documents", '/');
WriteLine("Split 'home/user/documents' by '/':");
for (int i = 0; i < folders.Count; i++)
{
    WriteLine("  [" + i + "] " + folders[i]);
}
