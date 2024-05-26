using System;
using SplashKitSDK;

public class TimerExample
{
    public static void Main()
    {
        SplashKitSDK.Timer timer1 = SplashKit.CreateTimer("Timer1");
        SplashKitSDK.Timer timer2 = SplashKit.CreateTimer("Timer2");

        SplashKit.StartTimer(timer1);
        SplashKit.StartTimer(timer2);

        SplashKit.Delay(2000); 

        Console.WriteLine($"Timer1: {SplashKit.TimerTicks(timer1)} ticks");
        Console.WriteLine($"Timer2: {SplashKit.TimerTicks(timer2)} ticks");

        // Free all timers
        SplashKit.FreeAllTimers();

        Console.WriteLine("All timers have been freed.");
    }
}
