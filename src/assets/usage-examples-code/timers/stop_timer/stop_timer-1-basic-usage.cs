using System;
using SplashKitSDK; // Import SplashKit namespace

using SplashKitTimer = SplashKitSDK.Timer; // Alias for SplashKit's Timer class

class Program
{
    static void Main(string[] args)
    {
        SplashKitTimer myTimer = new SplashKitTimer("my_timer");
        myTimer.Start();
        Console.WriteLine("Timer started.");
        System.Threading.Thread.Sleep(2000); 

        // Stop the timer
        myTimer.Stop();
        Console.WriteLine("Timer stopped.");


        System.Threading.Thread.Sleep(3000); 
        myTimer.Reset();
        Console.WriteLine("Timer reset.");
        System.Threading.Thread.Sleep(1000); 
        myTimer.Start();
        Console.WriteLine("Timer restarted.");
        System.Threading.Thread.Sleep(500); 
        myTimer.Dispose();
        Console.WriteLine("Timer resource disposed.");
    }
}
