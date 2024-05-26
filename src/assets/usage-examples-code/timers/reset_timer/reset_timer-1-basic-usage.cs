 using System;
using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        SplashKitSDK.Timer myTimer = new SplashKitSDK.Timer("my_timer");
        myTimer.Start();
        SplashKitSDK.SplashKit.Delay(2000);
        
        // Reset the timer
        SplashKitSDK.SplashKit.ResetTimer(myTimer);
        
        Console.WriteLine("Timer reset!");
        myTimer.Stop();
        myTimer.Dispose();
    }
}
