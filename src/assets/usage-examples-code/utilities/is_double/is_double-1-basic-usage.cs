using static SplashKitSDK.SplashKit;
using System;

public static class Utilities
{
    public static bool IsDouble(string text)
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

        if (Utilities.IsDouble(input))
        {
            double value = Convert.ToDouble(input);
            Console.WriteLine("The string contains double value: " + value);
        }
        else
        {
            Console.WriteLine("The input is not a valid double.");
        }
    }
}
