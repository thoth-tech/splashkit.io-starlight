using static SplashKitSDK.SplashKit;
using System;

public static class Utilities
{
    public static bool IsNumber(string text)
    {
        double result;
        return double.TryParse(text, out result);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (Utilities.IsNumber(input))
        {
            double value = double.Parse(input);
            Console.WriteLine("The string contains number value: " + value);
        }
        else
        {
            Console.WriteLine("The input is not a valid number.");
        }
    }
}
