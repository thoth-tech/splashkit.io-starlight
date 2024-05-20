using static SplashKitSDK.SplashKit;
using System;

bool IsNumber(string text)
{
    double result;
    return double.TryParse(text, out result);
}

Console.Write("Enter a number: ");
string input = Console.ReadLine();

if (IsNumber(input))
{
    double value = ConvertToDouble(input);
    Console.WriteLine("The converted double value is: " + value);
}
else
{
    Console.WriteLine("The input is not a valid number.");
}

public static class Utilities
{
    public static double ConvertToDouble(string text)
    {
        return double.Parse(text);
    }
}
