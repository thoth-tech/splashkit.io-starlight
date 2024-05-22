using static SplashKitSDK.SplashKit;
using System;

bool IsInteger(string text)
{
    int result;
    return int.TryParse(text, out result);
}

Console.Write("Enter a number: ");
string input = Console.ReadLine();

if (IsInteger(input))
{
    int value = Utilities.ConvertToInteger(input);
    Console.WriteLine("The converted integer value is: " + value);
}
else
{
    Console.WriteLine("The input is not a valid integer.");
}

public static class Utilities
{
    public static int ConvertToInteger(string text)
    {
        return int.Parse(text);
    }
}
