using System;
using SplashKitSDK;

namespace Test
{
    class Program
    {
        static void Main()
        {
            SplashKitSDK.Timer myTimer = SplashKit.CreateTimer("MyTimer");

            SplashKit.StartTimer(myTimer);
            SplashKit.Delay(2000);

            // Pause the timer
            SplashKit.PauseTimer(myTimer);

            SplashKit.Delay(2000);
            double elapsedSeconds = SplashKit.TimerTicks(myTimer) / 1000.0;
            Console.WriteLine($"Elapsed time (after pausing): {elapsedSeconds} seconds");
            SplashKit.FreeAllTimers();
        }
    }
}
