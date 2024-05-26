using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("MyTimer");

        // Check if SplashKit has a timer named "MyTimer"
        bool hasMyTimer = SplashKit.HasTimer("MyTimer");

        Console.WriteLine($"SplashKit have a timer named 'MyTimer'? {hasMyTimer}");

        SplashKit.FreeAllTimers();
    }
}
