using SplashKitSDK;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        string originalText = Console.ReadLine();
        string uppercaseText = SplashKit.ToUppercase(originalText);
        Console.WriteLine("Original Text: " + originalText);
        Console.WriteLine("Uppercase Text: " + uppercaseText);
    }
}
