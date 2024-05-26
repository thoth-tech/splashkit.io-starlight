using System;
using SplashKitSDK;

public class TimerExample
{
    public static void Main()
    {
        SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("MyTimer");

        SplashKit.StartTimer(myTimer);

        SplashKit.Delay(2000);

        Console.WriteLine($"MyTimer: {SplashKit.TimerTicks(myTimer)} ticks");

        // Free the timer
        SplashKit.FreeTimer(myTimer);

        Console.WriteLine("The timer has been freed.");
    }
}
