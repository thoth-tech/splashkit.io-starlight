using static SplashKitSDK.SplashKit;

string text = "I like cats. cats are great. I have two cats.";
WriteLine("Original: " + text);

// Replace all occurrences of "cats" with "dogs"
string result = ReplaceAll(text, "cats", "dogs");
WriteLine("Replaced: " + result);

string greeting = "Hello World! Hello Everyone!";
WriteLine("\nOriginal: " + greeting);

// Replace all occurrences of "Hello" with "Hi"
string newGreeting = ReplaceAll(greeting, "Hello", "Hi");
WriteLine("Replaced: " + newGreeting);
