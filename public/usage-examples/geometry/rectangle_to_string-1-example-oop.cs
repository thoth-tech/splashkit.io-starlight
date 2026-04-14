using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        Rectangle rect = SplashKit.RectangleFrom(10, 20, 100, 50);
        string result = SplashKit.RectangleToString(rect);

        Console.WriteLine(result);
    }
}