using static SplashKitSDK.SplashKit;
using System;

public static class Utilities
{
    public static bool IsInteger(string text)
    {
        int result;
        return int.TryParse(text, out result);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (Utilities.IsInteger(input))
        {
            int value = int.Parse(input);
            Console.WriteLine("The string contains integer value: " + value);
        }
        else
        {
            Console.WriteLine("The input is not a valid integer.");
        }
    }
}
