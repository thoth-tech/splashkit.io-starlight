using static SplashKitSDK.SplashKit;

// Prompt user for input string and delimiter
Write("Enter a string to split: ");
string text = ReadLine();

Write("Enter a delimiter character: ");
string delimiterInput = ReadLine();

// Ensure the delimiter is a single character
if (delimiterInput.Length != 1)
{
    WriteLine("Please enter a single character as the delimiter.");
}
else
{
    char delimiter = delimiterInput[0];

    // Split the input string
    List<string> result = Split(text, delimiter);

    // Display the split substrings
    WriteLine("Split result:");
    foreach (string part in result)
    {
        WriteLine($"- {part}");
    }
}