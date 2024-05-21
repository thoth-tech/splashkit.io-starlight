using static SplashKitSDK.SplashKit;  

// Example 1: Prompt and read a single character from the user
Write("Please enter a letter: ");
char input = ReadChar();
WriteLine("You entered: ");
WriteLine(input.ToString());
