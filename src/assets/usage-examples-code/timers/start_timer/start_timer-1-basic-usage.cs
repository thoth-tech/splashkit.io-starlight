using SplashKitSDK;
using System;

class Program
{
    static void Main(string[] args)
    {
        SplashKitSDK.Timer myTimer = new SplashKitSDK.Timer("my_timer");

        // Start the timer 
        SplashKit.StartTimer(myTimer);

        Console.WriteLine("Timer started.");
    }
}
