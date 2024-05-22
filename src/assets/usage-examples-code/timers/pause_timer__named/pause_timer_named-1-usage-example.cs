using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
     
        SplashKit.CreateTimer("myTimer");
        SplashKit.StartTimer("myTimer");
        SplashKit.Delay(5000); 

        SplashKit.PauseTimer("myTimer");

        ulong ticks = SplashKit.TimerTicks("myTimer");
        int seconds = (int)(ticks / 1000);

        Console.WriteLine($"Timer paused after {seconds} seconds");
    }
}
