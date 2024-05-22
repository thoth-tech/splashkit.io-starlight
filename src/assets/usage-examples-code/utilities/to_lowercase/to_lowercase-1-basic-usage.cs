using SplashKitSDK;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        string originalText = Console.ReadLine();
        string lowercaseText = SplashKit.ToLowercase(originalText);
        Console.WriteLine("Original Text: " + originalText);
        Console.WriteLine("Lowercase Text: " + lowercaseText);
    }
}
