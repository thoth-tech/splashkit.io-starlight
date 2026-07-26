using SplashKitSDK;

// Replace all occurrences of "foo" with "bar" in a sentence.
string text = "foo is fun, and foo is useful.";
string updated = SplashKit.ReplaceAll(text, "foo", "bar");

Console.WriteLine("Original: " + text);
Console.WriteLine("Updated: " + updated);